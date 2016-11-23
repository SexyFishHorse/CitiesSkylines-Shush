namespace SexyFishHorse.CitiesSkylines.Shush
{
    using ICities;
    using Infrastructure;
    using Infrastructure.UI;

    public class Mod : IUserMod, IUserModWithOptionsPanel<Mod>
    {
        public string Description
        {
            get
            {
                return "Remove notifications from the game";
            }
        }

        public string Name
        {
            get
            {
                return "Shush";
            }
        }

        public void OnSettingsUI(UIHelperBase uiHelperBase)
        {
            var uiHelper = uiHelperBase.AsStronglyTyped();
        }
    }
}
