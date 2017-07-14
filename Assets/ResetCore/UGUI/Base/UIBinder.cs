﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResetCore.UGUI
{
    public abstract class UIBinder
    {
        //前缀
        public static readonly string genableSign = "g-";
        //自定义UIView命名空间
        public static readonly string uiBinderNameSpace = "ResetCore.UGUI.Binder";
        //UIView储存位置
        public static readonly string uiBinderScriptPath = "Scripts/UI/Binder";

        /// <summary>
        /// 绑定
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public abstract void Bind(UIView view, UIModel model);

    }
}
