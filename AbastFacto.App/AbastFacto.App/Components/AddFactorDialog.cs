using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

using AbastFacto.App.Shared;
using AbastFacto.App.Services;

namespace AbastFacto.App.Components
{
    public partial class AddFactorDialog
    {
        public CharacterizationFactor Factor { get; set; } = new CharacterizationFactor { };
        [Inject]
        public IFactorDataService FactorDataService { get; set; }
        public bool ShowDialog { get; set; }
        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }


        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }

        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }

        private void ResetDialog()
        {
            Factor = new CharacterizationFactor { };
        }
        protected async Task HandleValidSubmit()
        {
            await FactorDataService.AddFactor(Factor);
            ShowDialog = false;

            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }


    }

}