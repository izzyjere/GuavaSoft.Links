using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuavaSoft.Links
{
    public class AnchorLinkProvider : ComponentBase, IDisposable
    {
        [Inject] public NavigationManager NavigationManager { get; set; }
        [Inject] public IJSRuntime JSRuntime { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }
        private Lazy<Task<IJSObjectReference>> moduleTask;
        string Anchor { get; set; }

        bool ForceScroll { get; set; }

        protected override void OnInitialized()
        {
            moduleTask = new(() => JSRuntime.InvokeAsync<IJSObjectReference>(
               "import", "./_content/GuavaSoft.Links/main.js").AsTask());
            base.OnInitialized();

            NavigationManager.LocationChanged += OnLocationChanged;
        }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
                ScrollToAnchor(forceScroll: true);

            return base.OnAfterRenderAsync(firstRender);
        }

        void OnLocationChanged(object sender, LocationChangedEventArgs args)
        {
            ScrollToAnchor(NavigationManager.ToAbsoluteUri(args.Location).Fragment);
        }

        async void ScrollToAnchor(string anchor = "", bool forceScroll = false)
        {
            var module = await moduleTask.Value;
            if (module != null)
            {
                if (!string.IsNullOrEmpty(anchor) || forceScroll)
                   await module.InvokeAsync<string>("scrollToAnchor", anchor);
            }
        }

        void IDisposable.Dispose()
        {
            NavigationManager.LocationChanged -= OnLocationChanged;
        }
    }
}
