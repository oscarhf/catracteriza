

using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

using AbastFacto.App.Shared;
using AbastFacto.App.Services;

namespace AbastFacto.App.Pages
{
    public partial class FactorEdit
    {
        [Inject]
        public IFactorDataService FactorDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string FactorId { get; set; }
        public CharacterizationFactor Factor { get; set; } = new CharacterizationFactor();

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;
        protected override async Task OnInitializedAsync()
        {
            Saved = false;
            int.TryParse(FactorId, out var factorId);

            if (factorId == 0) //new employee is being created
            {
                //add some defaults
                Factor = new CharacterizationFactor { };
            }
            else
            {
                Factor = await FactorDataService.GetFactorDetails(int.Parse(FactorId));
            }
        }
        protected async Task HandleValidSubmit()
        {
            Saved = false;
            if (Factor.FactorId == 0) //new
            {
                var addedFactor = await FactorDataService.AddFactor(Factor); //if everything was Ok returns the Added factor
                if (addedFactor != null)
                {
                    StatusClass = "alert-success";
                    Message = "New factor added successfully.";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong adding the new factor. Please try again.";
                    Saved = false;
                }
            }
            else // update
            {
                await FactorDataService.UpdateFactor(Factor);
                StatusClass = "alert-success";
                Message = "Factor updated successfully.";
                Saved = true;
            }
        }
        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again.";

        }

        protected async Task DeleteFactor()
        {
            await FactorDataService.DeleteFactor(Factor.FactorId);

            StatusClass = "alert-success";
            Message = "Deleted successfully";

            Saved = true;
        }
        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/factoroverview");
        }
    }
}
