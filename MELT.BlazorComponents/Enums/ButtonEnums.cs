using MELT.BlazorComponents.Attributes;

namespace MELT.BlazorComponents.Enums
{    
    public enum EButtonVariant
    {
        [DisplayDescription("btn-outline-dark")]
        Default,
        [DisplayDescription("btn-primary")]
        Primary,
        [DisplayDescription("btn-outline-primary")]
        PrimaryOutline,
        [DisplayDescription("btn-outline-secondary")]
        SecondaryOutline,
        [DisplayDescription("btn-outline-success")]
        SuccessOutline,
        [DisplayDescription("btn-outline-danger")]
        DangerOutline,
        [DisplayDescription("btn-outline-info")]
        InfoOutline
    }

    public enum EButtonSize
    {
        [DisplayDescription("")]
        Default,
        [DisplayDescription("btn-sm")]
        SM,
        [DisplayDescription("btn-lg")]
        LG
    }
}
