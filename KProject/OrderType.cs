
using System.ComponentModel;

namespace KProject
{
    public enum OrderType
    {
        [Description("Створено")] 
        CREATED,

        [Description("Скасовано")] 
        CANCELED,

        [Description("В дорозі")] 
        ON_THE_ROAD,

        [Description("Доставлено")] 
        DELIVERED,

        [Description("Отримано")] 
        RECEIVED
    }
}
