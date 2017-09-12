﻿using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using ResetCore.Util;
using ResetCore.Asset;

public partial class PathConfig
{

    #region 全局
    //插件统一文件夹名
    public static string PluginsFolderName = "Plugins";

    //ResetCore根目录
    public static readonly string ResetCorePath = Application.dataPath + "/ResetCore/";

    //Plugins目录
    public static readonly string pluginPath = Path.Combine(Application.dataPath, PluginsFolderName);

    private static string _projectPath;
    //工程目录
    public static string projectPath
    {
        get
        {
            if (_projectPath == null)
            {
                DirectoryInfo directory = new DirectoryInfo(Application.dataPath);
                _projectPath = directory.Parent.FullName.Replace("\\", "/");
            }
            return _projectPath;
        }
    }
    //沙盒目录
    public static readonly string persistentDataPath = 
        Path.Combine(Application.persistentDataPath, Application.productName);

    //
    public static readonly string assetResourcePath = "Assets/Resources/";

    //Resources路径
    public static readonly string resourcePath = Application.dataPath + "/Resources/";

    #endregion 全局

    #region GameData相关

    public enum DataType
    {
        Xml,
        Obj,
        Protobuf,
        Json,
        Pref,
        Localization,
        Core
    }

    //数据所在的Bundle名
    public static readonly string DataBundleName = "data";

    //Excelm默认存放地址
    public static readonly string localGameDataExcelPath = Application.dataPath + "/Excel/";

    //Data专用的Resources
    public static readonly string localDataResourcesPath = ResetCorePath + "AutoGenerateData/";
    public static readonly string loacalDataPathInResources = "GameDatas/DataResources/";

    //游戏数据根目录
    public static readonly string localGameDataSourceRoot = localDataResourcesPath + loacalDataPathInResources;
    //游戏数据类文件根目录
    public static readonly string localGameDataClassRoot = ResetCorePath + "AutoGenerateData/GameDatas/DataClasses/";

    //存放游戏数据源文件的目录
    public static string GetLocalGameDataPath(DataType type)
    {
        return localGameDataSourceRoot + type.ToString() + "/";
    }
    //存放GameDataClass的路径
    public static string GetLoaclGameDataClassPath(DataType type)
    {
        return localGameDataClassRoot + type.ToString() + "/";
    }
    //获取相对于Resources的路径
    public static string GetLocalGameDataResourcesPath(DataType type)
    {
        return loacalDataPathInResources + type.ToString() + "/";
    }

    /// <summary>
    /// 本地化数据存放地址
    /// </summary>
    public static string LanguageDataExcelPath
    {
        get
        {
            return PathEx.Combine(ResetCorePath, "Tools/DataGener", "Localization/Excel/LocalizationData.xlsx");
        }
    }

    //存放本地化数据的地址
    public static readonly string LanguageDataPath =
        PathConfig.GetLocalGameDataPath(DataType.Localization) + "LocalizationData.xml";
    //存放PrefData GameData类的地址
    public static readonly string localLanguageDataClassPath =
        PathConfig.GetLoaclGameDataClassPath(DataType.Localization) + "LocalizationData.cs";

    #endregion

}