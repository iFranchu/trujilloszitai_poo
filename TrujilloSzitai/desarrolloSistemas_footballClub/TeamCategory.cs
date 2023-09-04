using System.ComponentModel;

namespace footballClub {
    enum TeamCategory {
        [Description("Primera división")]
        PRIMERA,
        [Description("Segunda división")]
        SEGUNDA,
        [Description("Tercera división")]
        TERCERA,
    }
}