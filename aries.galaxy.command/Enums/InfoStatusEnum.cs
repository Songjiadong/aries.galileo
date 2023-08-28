﻿using System.ComponentModel;

namespace aries.galaxy.command
{
    public enum InfoStatusEnum
    {
        [Description("初始化")]
        Init = 0,
        [Description("已编辑")]
        Edited = 1,
        [Description("可提交")]
        CanSubmit =2
    }
}
