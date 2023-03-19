namespace MELT.BlazorComponents.Attributes
{
    public class DisplayDescription : Attribute
    {
        public string NameToShow { get; set; }

        public DisplayDescription(string _nameToShow)
        {
            NameToShow = _nameToShow;
        }
    }
}
