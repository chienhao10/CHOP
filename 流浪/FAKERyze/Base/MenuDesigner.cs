using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace FAKERyze.Base
{
    internal class MenuDesigner
    {
        public static Menu RyzeUi;
        public static Menu ConfigUi;

        internal static void Initialize()
        {
            RyzeUi = MainMenu.AddMenu("CH汉化-FAKERyze", "ryze", "Enelx FAKERyze");
            RyzeUi.AddGroupLabel("全自动流浪脚本");

            ConfigUi = RyzeUi.AddSubMenu("设置");
            ConfigUi.AddGroupLabel("骚扰 - 设置");
            ConfigUi.Add("HarassE", new CheckBox("使用 E"));
            ConfigUi.AddGroupLabel("线圈 - 设置");
            ConfigUi.Add("DrawQ", new CheckBox("显示 Q"));
        }
    }
}