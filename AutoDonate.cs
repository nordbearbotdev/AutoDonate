// Версия AutoDonate: 0.1
// Название: AutoDonate
// Описание:

//
//    ___       __       ___                __     
//   / _ |__ __/ /____  / _ \___  ___ ___ _/ /____ 
//  / __ / // / __/ _ \/ // / _ \/ _ / _ `/ __/ -_)
// /_/ |_\_,_/\__/\___/____/\___/_//_\_,_/\__/\__/ 
//                                                 

// Модули
using System
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using Terraria;
using TerrariaApi.Server;
using TShockAPI
using TShockAPI.DB


namespace AutoDonate
{ 
  [ApiVersion(2, 1)] ////////////////////Версия API 2,1
    public class AutoDonate : TerrariaPlugin
