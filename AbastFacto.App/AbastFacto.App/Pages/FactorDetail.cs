using AbastFacto.App.Services;
using AbastFacto.App.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AbastFacto.ComponentsLibrary.Map;

namespace AbastFacto.App.Pages
{
    public partial class FactorDetail
    {
        [Parameter]
        public string FactorId { get; set; }
        public CharacterizationFactor Factor { get; set; } = new CharacterizationFactor();

        public List<Marker> MapMarkers { get; set; } = new List<Marker>();

        [Inject]
        public IFactorDataService FactorDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {

            Factor = await FactorDataService.GetFactorDetails(int.Parse(FactorId));

            MapMarkers = new List<Marker>
            {
                new Marker{Description = $"{Factor.ShortName}" ,  ShowPopup = false, Y = 50.850299999999997, X = 4.3517000000000001}
            };

        }


    }
}
