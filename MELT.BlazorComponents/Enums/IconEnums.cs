using MELT.BlazorComponents.Attributes;

namespace MELT.BlazorComponents.Enums
{
    public enum EIconWeight
    {
        [DisplayDescription("fas")]
        Solid,
        [DisplayDescription("fad")]
        Duotone,
        [DisplayDescription("far")]
        Regular,
        [DisplayDescription("fal")]
        Light,
        [DisplayDescription("fat")]
        Thin
    }

    public enum EIconSize
    {
        [DisplayDescription("")]
        Default,
        [DisplayDescription("fa-xl")]
        Large,
        [DisplayDescription("fa-2x")]
        X2,
        [DisplayDescription("fa-3x")]
        X3,
        [DisplayDescription("fa-4x")]
        X4,
        [DisplayDescription("fa-5x")]
        X5,
        [DisplayDescription("fa-6x")]
        X6,
        [DisplayDescription("fa-7x")]
        X7,
        [DisplayDescription("fa-8x")]
        X8,
        [DisplayDescription("fa-9x")]
        X9,
        [DisplayDescription("fa-10x")]
        X10
    }
}
