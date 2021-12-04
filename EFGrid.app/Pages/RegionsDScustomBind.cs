using Microsoft.AspNetCore.Components;
using Syncfusion.Blazor.Grids;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using EFGrid.app.Data;
using EFGrid.classes.DbModel;

namespace EFGrid.app.Pages
{
    public partial class RegionsDScustomBind
    {

        [Inject]
        public IRegionDataService InjctdSvc { get; set; }

        [Inject]
        public NavigationManager NavManager { get; set; }

        public IEnumerable<Region> Regz { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Regz = await InjctdSvc.Regions();
        }


        public void ActionBeginHandler(ActionEventArgs<Region> Args)
        {
            if (Args.RequestType.Equals(Syncfusion.Blazor.Grids.Action.Save))
            {
                if (Args.Action == "Add")
                {
                     InjctdSvc.AddNew(Args.Data);
                }
                else
                {
                    InjctdSvc.UpdateRec(Args.Data);
                }
            }
            if (Args.RequestType.Equals(Syncfusion.Blazor.Grids.Action.Delete))
            {
                InjctdSvc.DeleteRec(Args.Data.RegionId);
            }
        }

        public void ActionCompleteHandler(ActionEventArgs<Region> Args)
        {
            if (Args.RequestType.Equals(Syncfusion.Blazor.Grids.Action.Save))
            {
                Console.WriteLine("usergrid.cs:ActionCompleteHandler");
                //NavManager.NavigateTo("/admin/usergrid", true);
                //this.StateHasChanged();
                //InvokeAsync(StateHasChanged);
            }
        }

        private void onToggleClick_Resolved(Microsoft.AspNetCore.Components.Web.MouseEventArgs args, Region cRec)
        {
            //https://www.syncfusion.com/forums/161255/using-button-in-sfgrid
            var val = cRec.RegionId;    // access the record value here.
            //NavManager.NavigateTo("/filetemplatedetail/" + fth.Ftsan);
        }


    }
}
