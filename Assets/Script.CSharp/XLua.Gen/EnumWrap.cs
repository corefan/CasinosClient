﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    
    public class DGTweeningEaseWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.Ease), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.Ease), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.Ease), L, null, 39, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Unset", DG.Tweening.Ease.Unset);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Linear", DG.Tweening.Ease.Linear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InSine", DG.Tweening.Ease.InSine);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutSine", DG.Tweening.Ease.OutSine);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutSine", DG.Tweening.Ease.InOutSine);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InQuad", DG.Tweening.Ease.InQuad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutQuad", DG.Tweening.Ease.OutQuad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutQuad", DG.Tweening.Ease.InOutQuad);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InCubic", DG.Tweening.Ease.InCubic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutCubic", DG.Tweening.Ease.OutCubic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutCubic", DG.Tweening.Ease.InOutCubic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InQuart", DG.Tweening.Ease.InQuart);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutQuart", DG.Tweening.Ease.OutQuart);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutQuart", DG.Tweening.Ease.InOutQuart);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InQuint", DG.Tweening.Ease.InQuint);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutQuint", DG.Tweening.Ease.OutQuint);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutQuint", DG.Tweening.Ease.InOutQuint);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InExpo", DG.Tweening.Ease.InExpo);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutExpo", DG.Tweening.Ease.OutExpo);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutExpo", DG.Tweening.Ease.InOutExpo);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InCirc", DG.Tweening.Ease.InCirc);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutCirc", DG.Tweening.Ease.OutCirc);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutCirc", DG.Tweening.Ease.InOutCirc);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InElastic", DG.Tweening.Ease.InElastic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutElastic", DG.Tweening.Ease.OutElastic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutElastic", DG.Tweening.Ease.InOutElastic);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InBack", DG.Tweening.Ease.InBack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutBack", DG.Tweening.Ease.OutBack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutBack", DG.Tweening.Ease.InOutBack);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InBounce", DG.Tweening.Ease.InBounce);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutBounce", DG.Tweening.Ease.OutBounce);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutBounce", DG.Tweening.Ease.InOutBounce);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Flash", DG.Tweening.Ease.Flash);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InFlash", DG.Tweening.Ease.InFlash);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "OutFlash", DG.Tweening.Ease.OutFlash);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "InOutFlash", DG.Tweening.Ease.InOutFlash);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "INTERNAL_Zero", DG.Tweening.Ease.INTERNAL_Zero);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "INTERNAL_Custom", DG.Tweening.Ease.INTERNAL_Custom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.Ease), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningEase(L, (DG.Tweening.Ease)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Unset"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.Unset);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Linear"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.Linear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InSine"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InSine);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutSine"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutSine);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutSine"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutSine);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InQuad"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InQuad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutQuad"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutQuad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutQuad"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutQuad);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InCubic"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InCubic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutCubic"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutCubic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutCubic"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutCubic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InQuart"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InQuart);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutQuart"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutQuart);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutQuart"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutQuart);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InQuint"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InQuint);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutQuint"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutQuint);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutQuint"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutQuint);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InExpo"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InExpo);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutExpo"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutExpo);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutExpo"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutExpo);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InCirc"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InCirc);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutCirc"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutCirc);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutCirc"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutCirc);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InElastic"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InElastic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutElastic"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutElastic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutElastic"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutElastic);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InBack"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InBack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutBack"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutBack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutBack"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutBack);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InBounce"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InBounce);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutBounce"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutBounce);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutBounce"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutBounce);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Flash"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.Flash);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InFlash"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InFlash);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "OutFlash"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.OutFlash);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "InOutFlash"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.InOutFlash);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "INTERNAL_Zero"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.INTERNAL_Zero);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "INTERNAL_Custom"))
                {
                    translator.PushDGTweeningEase(L, DG.Tweening.Ease.INTERNAL_Custom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.Ease!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.Ease! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningLoopTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.LoopType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.LoopType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.LoopType), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Restart", DG.Tweening.LoopType.Restart);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Yoyo", DG.Tweening.LoopType.Yoyo);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Incremental", DG.Tweening.LoopType.Incremental);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.LoopType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningLoopType(L, (DG.Tweening.LoopType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Restart"))
                {
                    translator.PushDGTweeningLoopType(L, DG.Tweening.LoopType.Restart);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Yoyo"))
                {
                    translator.PushDGTweeningLoopType(L, DG.Tweening.LoopType.Yoyo);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Incremental"))
                {
                    translator.PushDGTweeningLoopType(L, DG.Tweening.LoopType.Incremental);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.LoopType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.LoopType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningPathModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.PathMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.PathMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.PathMode), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Ignore", DG.Tweening.PathMode.Ignore);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Full3D", DG.Tweening.PathMode.Full3D);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopDown2D", DG.Tweening.PathMode.TopDown2D);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Sidescroller2D", DG.Tweening.PathMode.Sidescroller2D);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.PathMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningPathMode(L, (DG.Tweening.PathMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Ignore"))
                {
                    translator.PushDGTweeningPathMode(L, DG.Tweening.PathMode.Ignore);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Full3D"))
                {
                    translator.PushDGTweeningPathMode(L, DG.Tweening.PathMode.Full3D);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopDown2D"))
                {
                    translator.PushDGTweeningPathMode(L, DG.Tweening.PathMode.TopDown2D);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Sidescroller2D"))
                {
                    translator.PushDGTweeningPathMode(L, DG.Tweening.PathMode.Sidescroller2D);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.PathMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.PathMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningPathTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.PathType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.PathType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.PathType), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Linear", DG.Tweening.PathType.Linear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CatmullRom", DG.Tweening.PathType.CatmullRom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.PathType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningPathType(L, (DG.Tweening.PathType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Linear"))
                {
                    translator.PushDGTweeningPathType(L, DG.Tweening.PathType.Linear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CatmullRom"))
                {
                    translator.PushDGTweeningPathType(L, DG.Tweening.PathType.CatmullRom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.PathType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.PathType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningRotateModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.RotateMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.RotateMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.RotateMode), L, null, 5, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fast", DG.Tweening.RotateMode.Fast);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "FastBeyond360", DG.Tweening.RotateMode.FastBeyond360);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WorldAxisAdd", DG.Tweening.RotateMode.WorldAxisAdd);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LocalAxisAdd", DG.Tweening.RotateMode.LocalAxisAdd);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.RotateMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningRotateMode(L, (DG.Tweening.RotateMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Fast"))
                {
                    translator.PushDGTweeningRotateMode(L, DG.Tweening.RotateMode.Fast);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "FastBeyond360"))
                {
                    translator.PushDGTweeningRotateMode(L, DG.Tweening.RotateMode.FastBeyond360);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WorldAxisAdd"))
                {
                    translator.PushDGTweeningRotateMode(L, DG.Tweening.RotateMode.WorldAxisAdd);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LocalAxisAdd"))
                {
                    translator.PushDGTweeningRotateMode(L, DG.Tweening.RotateMode.LocalAxisAdd);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.RotateMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.RotateMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class DGTweeningScrambleModeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(DG.Tweening.ScrambleMode), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(DG.Tweening.ScrambleMode), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(DG.Tweening.ScrambleMode), L, null, 7, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", DG.Tweening.ScrambleMode.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "All", DG.Tweening.ScrambleMode.All);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Uppercase", DG.Tweening.ScrambleMode.Uppercase);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Lowercase", DG.Tweening.ScrambleMode.Lowercase);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Numerals", DG.Tweening.ScrambleMode.Numerals);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom", DG.Tweening.ScrambleMode.Custom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(DG.Tweening.ScrambleMode), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushDGTweeningScrambleMode(L, (DG.Tweening.ScrambleMode)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushDGTweeningScrambleMode(L, DG.Tweening.ScrambleMode.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "All"))
                {
                    translator.PushDGTweeningScrambleMode(L, DG.Tweening.ScrambleMode.All);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Uppercase"))
                {
                    translator.PushDGTweeningScrambleMode(L, DG.Tweening.ScrambleMode.Uppercase);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Lowercase"))
                {
                    translator.PushDGTweeningScrambleMode(L, DG.Tweening.ScrambleMode.Lowercase);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Numerals"))
                {
                    translator.PushDGTweeningScrambleMode(L, DG.Tweening.ScrambleMode.Numerals);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom"))
                {
                    translator.PushDGTweeningScrambleMode(L, DG.Tweening.ScrambleMode.Custom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for DG.Tweening.ScrambleMode!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for DG.Tweening.ScrambleMode! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIRelationTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.RelationType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.RelationType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.RelationType), L, null, 26, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left_Left", FairyGUI.RelationType.Left_Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left_Center", FairyGUI.RelationType.Left_Center);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Left_Right", FairyGUI.RelationType.Left_Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Center_Center", FairyGUI.RelationType.Center_Center);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right_Left", FairyGUI.RelationType.Right_Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right_Center", FairyGUI.RelationType.Right_Center);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Right_Right", FairyGUI.RelationType.Right_Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top_Top", FairyGUI.RelationType.Top_Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top_Middle", FairyGUI.RelationType.Top_Middle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top_Bottom", FairyGUI.RelationType.Top_Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Middle_Middle", FairyGUI.RelationType.Middle_Middle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom_Top", FairyGUI.RelationType.Bottom_Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom_Middle", FairyGUI.RelationType.Bottom_Middle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Bottom_Bottom", FairyGUI.RelationType.Bottom_Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Width", FairyGUI.RelationType.Width);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Height", FairyGUI.RelationType.Height);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftExt_Left", FairyGUI.RelationType.LeftExt_Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LeftExt_Right", FairyGUI.RelationType.LeftExt_Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightExt_Left", FairyGUI.RelationType.RightExt_Left);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "RightExt_Right", FairyGUI.RelationType.RightExt_Right);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopExt_Top", FairyGUI.RelationType.TopExt_Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TopExt_Bottom", FairyGUI.RelationType.TopExt_Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomExt_Top", FairyGUI.RelationType.BottomExt_Top);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BottomExt_Bottom", FairyGUI.RelationType.BottomExt_Bottom);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Size", FairyGUI.RelationType.Size);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.RelationType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIRelationType(L, (FairyGUI.RelationType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Left_Left"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Left_Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left_Center"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Left_Center);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Left_Right"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Left_Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Center_Center"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Center_Center);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right_Left"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Right_Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right_Center"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Right_Center);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Right_Right"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Right_Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top_Top"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Top_Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top_Middle"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Top_Middle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top_Bottom"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Top_Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Middle_Middle"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Middle_Middle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom_Top"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Bottom_Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom_Middle"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Bottom_Middle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Bottom_Bottom"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Bottom_Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Width"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Width);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Height"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Height);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftExt_Left"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.LeftExt_Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LeftExt_Right"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.LeftExt_Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightExt_Left"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.RightExt_Left);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "RightExt_Right"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.RightExt_Right);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopExt_Top"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.TopExt_Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "TopExt_Bottom"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.TopExt_Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomExt_Top"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.BottomExt_Top);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BottomExt_Bottom"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.BottomExt_Bottom);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Size"))
                {
                    translator.PushFairyGUIRelationType(L, FairyGUI.RelationType.Size);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.RelationType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.RelationType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyGUIEaseTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyGUI.EaseType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyGUI.EaseType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyGUI.EaseType), L, null, 33, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Linear", FairyGUI.EaseType.Linear);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SineIn", FairyGUI.EaseType.SineIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SineOut", FairyGUI.EaseType.SineOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SineInOut", FairyGUI.EaseType.SineInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuadIn", FairyGUI.EaseType.QuadIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuadOut", FairyGUI.EaseType.QuadOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuadInOut", FairyGUI.EaseType.QuadInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CubicIn", FairyGUI.EaseType.CubicIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CubicOut", FairyGUI.EaseType.CubicOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CubicInOut", FairyGUI.EaseType.CubicInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuartIn", FairyGUI.EaseType.QuartIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuartOut", FairyGUI.EaseType.QuartOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuartInOut", FairyGUI.EaseType.QuartInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuintIn", FairyGUI.EaseType.QuintIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuintOut", FairyGUI.EaseType.QuintOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QuintInOut", FairyGUI.EaseType.QuintInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ExpoIn", FairyGUI.EaseType.ExpoIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ExpoOut", FairyGUI.EaseType.ExpoOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ExpoInOut", FairyGUI.EaseType.ExpoInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CircIn", FairyGUI.EaseType.CircIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CircOut", FairyGUI.EaseType.CircOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CircInOut", FairyGUI.EaseType.CircInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ElasticIn", FairyGUI.EaseType.ElasticIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ElasticOut", FairyGUI.EaseType.ElasticOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ElasticInOut", FairyGUI.EaseType.ElasticInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BackIn", FairyGUI.EaseType.BackIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BackOut", FairyGUI.EaseType.BackOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BackInOut", FairyGUI.EaseType.BackInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BounceIn", FairyGUI.EaseType.BounceIn);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BounceOut", FairyGUI.EaseType.BounceOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BounceInOut", FairyGUI.EaseType.BounceInOut);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Custom", FairyGUI.EaseType.Custom);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyGUI.EaseType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyGUIEaseType(L, (FairyGUI.EaseType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Linear"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.Linear);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SineIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.SineIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SineOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.SineOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SineInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.SineInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuadIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuadIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuadOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuadOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuadInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuadInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CubicIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.CubicIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CubicOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.CubicOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CubicInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.CubicInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuartIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuartIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuartOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuartOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuartInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuartInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuintIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuintIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuintOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuintOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "QuintInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.QuintInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ExpoIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.ExpoIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ExpoOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.ExpoOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ExpoInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.ExpoInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CircIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.CircIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CircOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.CircOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CircInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.CircInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ElasticIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.ElasticIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ElasticOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.ElasticOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "ElasticInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.ElasticInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BackIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.BackIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BackOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.BackOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BackInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.BackInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BounceIn"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.BounceIn);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BounceOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.BounceOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "BounceInOut"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.BounceInOut);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Custom"))
                {
                    translator.PushFairyGUIEaseType(L, FairyGUI.EaseType.Custom);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyGUI.EaseType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyGUI.EaseType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class Casinos_eProjectItemDisplayNameKeyWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Casinos._eProjectItemDisplayNameKey), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Casinos._eProjectItemDisplayNameKey), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Casinos._eProjectItemDisplayNameKey), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Gold", Casinos._eProjectItemDisplayNameKey.Gold);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Diamond", Casinos._eProjectItemDisplayNameKey.Diamond);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Casinos._eProjectItemDisplayNameKey), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushCasinos_eProjectItemDisplayNameKey(L, (Casinos._eProjectItemDisplayNameKey)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Gold"))
                {
                    translator.PushCasinos_eProjectItemDisplayNameKey(L, Casinos._eProjectItemDisplayNameKey.Gold);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Diamond"))
                {
                    translator.PushCasinos_eProjectItemDisplayNameKey(L, Casinos._eProjectItemDisplayNameKey.Diamond);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Casinos._eProjectItemDisplayNameKey!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Casinos._eProjectItemDisplayNameKey! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class _eAsyncAssetLoadTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(_eAsyncAssetLoadType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(_eAsyncAssetLoadType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(_eAsyncAssetLoadType), L, null, 7, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LocalBundle", _eAsyncAssetLoadType.LocalBundle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WWWBundle", _eAsyncAssetLoadType.WWWBundle);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LocalBundleAsset", _eAsyncAssetLoadType.LocalBundleAsset);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WWWBundleAsset", _eAsyncAssetLoadType.WWWBundleAsset);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LocalRawAsset", _eAsyncAssetLoadType.LocalRawAsset);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "WWWRawAsset", _eAsyncAssetLoadType.WWWRawAsset);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(_eAsyncAssetLoadType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.Push_eAsyncAssetLoadType(L, (_eAsyncAssetLoadType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "LocalBundle"))
                {
                    translator.Push_eAsyncAssetLoadType(L, _eAsyncAssetLoadType.LocalBundle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WWWBundle"))
                {
                    translator.Push_eAsyncAssetLoadType(L, _eAsyncAssetLoadType.WWWBundle);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LocalBundleAsset"))
                {
                    translator.Push_eAsyncAssetLoadType(L, _eAsyncAssetLoadType.LocalBundleAsset);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WWWBundleAsset"))
                {
                    translator.Push_eAsyncAssetLoadType(L, _eAsyncAssetLoadType.WWWBundleAsset);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "LocalRawAsset"))
                {
                    translator.Push_eAsyncAssetLoadType(L, _eAsyncAssetLoadType.LocalRawAsset);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "WWWRawAsset"))
                {
                    translator.Push_eAsyncAssetLoadType(L, _eAsyncAssetLoadType.WWWRawAsset);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for _eAsyncAssetLoadType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for _eAsyncAssetLoadType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class _ePayTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(_ePayType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(_ePayType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(_ePayType), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "wx", _ePayType.wx);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "alipay", _ePayType.alipay);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "iap", _ePayType.iap);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(_ePayType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.Push_ePayType(L, (_ePayType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "wx"))
                {
                    translator.Push_ePayType(L, _ePayType.wx);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "alipay"))
                {
                    translator.Push_ePayType(L, _ePayType.alipay);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "iap"))
                {
                    translator.Push_ePayType(L, _ePayType.iap);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for _ePayType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for _ePayType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class Casinos_eEditorRunSourcePlatformWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Casinos._eEditorRunSourcePlatform), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Casinos._eEditorRunSourcePlatform), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Casinos._eEditorRunSourcePlatform), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Android", Casinos._eEditorRunSourcePlatform.Android);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IOS", Casinos._eEditorRunSourcePlatform.IOS);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PC", Casinos._eEditorRunSourcePlatform.PC);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Casinos._eEditorRunSourcePlatform), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushCasinos_eEditorRunSourcePlatform(L, (Casinos._eEditorRunSourcePlatform)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Android"))
                {
                    translator.PushCasinos_eEditorRunSourcePlatform(L, Casinos._eEditorRunSourcePlatform.Android);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "IOS"))
                {
                    translator.PushCasinos_eEditorRunSourcePlatform(L, Casinos._eEditorRunSourcePlatform.IOS);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PC"))
                {
                    translator.PushCasinos_eEditorRunSourcePlatform(L, Casinos._eEditorRunSourcePlatform.PC);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Casinos._eEditorRunSourcePlatform!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Casinos._eEditorRunSourcePlatform! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}