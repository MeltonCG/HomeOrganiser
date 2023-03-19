using Microsoft.AspNetCore.Components;

namespace MELT.BlazorComponents.Base
{
    public abstract class MeltComponentBase: ComponentBase
    {
        /// <summary>
        /// User class names, separated by space.
        /// </summary>
        [Parameter]
        public string Class { get; set; }

        /// <summary>
        /// Attributes carries all attributes you add to the component that don't match any of its parameters.
        /// They will be added to the underlying HTML tag.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> Attributes { get; set; } = new Dictionary<string, object>();
    }
}
