
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

using AbastFacto.App.Shared;
using AbastFacto.App.Services;
using AbastFacto.App.Components;

namespace AbastFacto.App.Pages
{
    public partial class FactorOverview

    {
        [Inject]
        public IFactorDataService FactorDataService { get; set; }
        public IEnumerable<CharacterizationFactor> Factors { get; set; }

        protected AddFactorDialog AddFactorDialog { get; set; }
        protected override async Task OnInitializedAsync()
        {

            //return base.OnInitializedAsync();
            Factors = (await FactorDataService.GetAllFactors()).ToList();

        }

        protected void QuickAddFactor()
        {
            AddFactorDialog.Show();
        }
        public async void AddFactorDialog_OnDialogClose()
        {
            Factors = (await FactorDataService.GetAllFactors()).ToList();
            StateHasChanged();
        }

    }

}