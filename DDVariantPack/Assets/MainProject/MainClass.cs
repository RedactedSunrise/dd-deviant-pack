using BepInEx;
using HG.Reflection;
using R2API.Utils;
using System.Security;
using System.Security.Permissions;

#pragma warning disable CS0618
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
#pragma warning restore CS0618
[module: UnverifiableCode]
[assembly: SearchableAttribute.OptIn]

namespace DDVariants
{
    [BepInDependency(Moonstorm.MoonstormSharedUtils.GUID)]
    [NetworkCompatibility]
    [BepInPlugin(GUID, NAME, VERSION)]
    public class MainClass : BaseUnityPlugin
    {
        public const string GUID = "com.DDTeam.DDVariantPack";
        public const string NAME = "DDVariantPack";
        public const string VERSION = "0.0.1";

        public static MainClass Instance;
        public void Awake()
        {
            Instance = this;
        }
    }
}
