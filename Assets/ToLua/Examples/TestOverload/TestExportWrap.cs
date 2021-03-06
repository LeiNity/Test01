//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TestExportWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TestExport), typeof(System.Object));
		L.RegFunction(".geti", new LuaCSFunction(get_Item));
		L.RegFunction("get_Item", new LuaCSFunction(get_Item));
		L.RegFunction(".seti", new LuaCSFunction(set_Item));
		L.RegFunction("set_Item", new LuaCSFunction(set_Item));
		L.RegFunction("TestByteBuffer", new LuaCSFunction(TestByteBuffer));
		L.RegFunction("Test", new LuaCSFunction(Test));
		L.RegFunction("TestChar", new LuaCSFunction(TestChar));
		L.RegFunction("Test33", new LuaCSFunction(Test33));
		L.RegFunction("TestGeneric", new LuaCSFunction(TestGeneric));
		L.RegFunction("TestEnum", new LuaCSFunction(TestEnum));
		L.RegFunction("TestCheckParamNumber", new LuaCSFunction(TestCheckParamNumber));
		L.RegFunction("TestCheckParamString", new LuaCSFunction(TestCheckParamString));
		L.RegFunction("TestReflection", new LuaCSFunction(TestReflection));
		L.RegFunction("TestRefGameObject", new LuaCSFunction(TestRefGameObject));
		L.RegFunction("DoClick", new LuaCSFunction(DoClick));
		L.RegFunction("TestNullable", new LuaCSFunction(TestNullable));
		L.RegFunction("New", new LuaCSFunction(_CreateTestExport));
		L.RegVar("this", _this, null);
		L.RegFunction("__tostring", new LuaCSFunction(ToLua.op_ToString));
		L.RegFunction("__le", new LuaCSFunction(op_LessThanOrEqual));
		L.RegVar("field", new LuaCSFunction(get_field), new LuaCSFunction(set_field));
		L.RegVar("OnClick", new LuaCSFunction(get_OnClick), new LuaCSFunction(set_OnClick));
		L.RegVar("OnRefEvent", new LuaCSFunction(get_OnRefEvent), new LuaCSFunction(set_OnRefEvent));
		L.RegVar("buffer", new LuaCSFunction(get_buffer), new LuaCSFunction(set_buffer));
		L.RegVar("Number", new LuaCSFunction(get_Number), new LuaCSFunction(set_Number));
		L.RegFunction("TestBuffer", new LuaCSFunction(TestExport_TestBuffer));
		L.RegFunction("TestRefEvent", new LuaCSFunction(TestExport_TestRefEvent));
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateTestExport(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				TestExport obj = new TestExport();
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<UnityEngine.Vector3[]>(L, 1))
			{
				UnityEngine.Vector3[] arg0 = ToLua.ToStructArray<UnityEngine.Vector3>(L, 1);
				TestExport obj = new TestExport(arg0);
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<UnityEngine.Vector3>(L, 1))
			{
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
				TestExport obj = new TestExport(arg0);
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				TestExport obj = new TestExport(arg0, arg1);
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: TestExport.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _get_this(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
				int o = obj[arg0];
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3)
			{
				TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
				char arg0 = (char)LuaDLL.luaL_checkinteger(L, 2);
				int arg1 = (int)LuaDLL.luaL_checkinteger(L, 3);
				int o = obj[arg0, arg1];
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to operator method: TestExport.this");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _set_this(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
				int arg1 = (int)LuaDLL.luaL_checkinteger(L, 3);
				obj[arg0] = arg1;
				return 0;
			}
			else if (count == 4)
			{
				TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
				char arg0 = (char)LuaDLL.luaL_checkinteger(L, 2);
				int arg1 = (int)LuaDLL.luaL_checkinteger(L, 3);
				int arg2 = (int)LuaDLL.luaL_checkinteger(L, 4);
				obj[arg0, arg1] = arg2;
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to operator method: TestExport.this");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _this(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushvalue(L, 1);
			LuaDLL.tolua_bindthis(L, _get_this, _set_this);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Item(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				int o = TestExport.get_Item(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<double>(L, 1))
			{
				double arg0 = (double)LuaDLL.lua_tonumber(L, 1);
				int o = TestExport.get_Item(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2)
			{
				TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
				int o = obj[arg0];
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<TestExport, char, int>(L, 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				char arg0 = (char)LuaDLL.lua_tointeger(L, 2);
				int arg1 = (int)LuaDLL.lua_tointeger(L, 3);
				int o = obj[arg0, arg1];
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<int, int, int>(L, 1))
			{
				int arg0 = (int)LuaDLL.lua_tointeger(L, 1);
				int arg1 = (int)LuaDLL.lua_tointeger(L, 2);
				int arg2 = (int)LuaDLL.lua_tointeger(L, 3);
				int o = TestExport.get_Item(arg0, arg1, arg2);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TestExport.get_Item");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Item(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				double arg0 = (double)LuaDLL.luaL_checknumber(L, 1);
				int o = TestExport.set_Item(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3)
			{
				TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
				int arg1 = (int)LuaDLL.luaL_checkinteger(L, 3);
				obj[arg0] = arg1;
				return 0;
			}
			else if (count == 4)
			{
				TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
				char arg0 = (char)LuaDLL.luaL_checkinteger(L, 2);
				int arg1 = (int)LuaDLL.luaL_checkinteger(L, 3);
				int arg2 = (int)LuaDLL.luaL_checkinteger(L, 4);
				obj[arg0, arg1] = arg2;
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TestExport.set_Item");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestByteBuffer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
			TestExport.TestBuffer arg0 = (TestExport.TestBuffer)ToLua.CheckDelegate<TestExport.TestBuffer>(L, 2);
			obj.TestByteBuffer(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Test(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<TestExport>(L, 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				int o = obj.Test();
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<TestExport, bool>(L, 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				bool arg0 = LuaDLL.lua_toboolean(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<TestExport, int[,]>(L, 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				int[,] arg0 = (int[,])ToLua.ToObject(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<TestExport, double>(L, 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				double arg0 = (double)LuaDLL.lua_tonumber(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<TestExport, LuaInterface.LuaOut<int>>(L, 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				int arg0;
				int o = obj.Test(out arg0);
				LuaDLL.lua_pushinteger(L, o);
				LuaDLL.lua_pushinteger(L, arg0);
				return 2;
			}
			else if (count == 2 && TypeChecker.CheckTypes<TestExport, string>(L, 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string, string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				int o = TestExport.Test(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<TestExport, TestExport.Space>(L, 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				TestExport.Space arg0 = (TestExport.Space)ToLua.ToObject(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<TestExport, object>(L, 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<TestExport, int, int>(L, 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tointeger(L, 2);
				int arg1 = (int)LuaDLL.lua_tointeger(L, 3);
				int o = obj.Test(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<TestExport, string[], bool>(L, 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				string[] arg0 = ToLua.ToStringArray(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				int o = obj.Test(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<TestExport, object, string>(L, 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				int o = obj.Test(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes<TestExport, object, string, int>(L, 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				string arg1 = ToLua.ToString(L, 3);
				int arg2 = (int)LuaDLL.lua_tointeger(L, 4);
				int o = obj.Test(arg0, arg1, arg2);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (TypeChecker.CheckTypes<TestExport>(L, 1) && TypeChecker.CheckParamsType<int>(L, 2, count - 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				int[] arg0 = ToLua.ToParamsNumber<int>(L, 2, count - 1);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (TypeChecker.CheckTypes<TestExport>(L, 1) && TypeChecker.CheckParamsType<string>(L, 2, count - 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				string[] arg0 = ToLua.ToParamsString(L, 2, count - 1);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (TypeChecker.CheckTypes<TestExport>(L, 1) && TypeChecker.CheckParamsType<object>(L, 2, count - 1))
			{
				TestExport obj = (TestExport)ToLua.ToObject(L, 1);
				object[] arg0 = ToLua.ToParamsObject(L, 2, count - 1);
				int o = obj.Test(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TestExport.Test");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestChar(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
			char arg0 = (char)LuaDLL.luaL_checkinteger(L, 2);
			int o = obj.Test(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Test33(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
			System.Action<int> arg0 = (System.Action<int>)ToLua.CheckDelegate<System.Action<int>>(L, 2);
			int o = obj.Test33(ref arg0);
			LuaDLL.lua_pushinteger(L, o);
			ToLua.Push(L, arg0);
			return 2;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestGeneric(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
			UnityEngine.Component arg0 = (UnityEngine.Component)ToLua.CheckObject<UnityEngine.Component>(L, 2);
			int o = obj.TestGeneric(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestEnum(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
			TestExport.Space arg0 = (TestExport.Space)ToLua.CheckObject(L, 2, TypeTraits<TestExport.Space>.type);
			int o = obj.TestEnum(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestCheckParamNumber(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
			int[] arg0 = ToLua.CheckParamsNumber<int>(L, 2, count - 1);
			int o = obj.TestCheckParamNumber(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestCheckParamString(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
			string[] arg0 = ToLua.CheckParamsString(L, 2, count - 1);
			string o = obj.TestCheckParamString(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestReflection(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			TestExport.TestReflection();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestRefGameObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject<UnityEngine.GameObject>(L, 1);
			TestExport.TestRefGameObject(ref arg0);
			ToLua.PushSealed(L, arg0);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
			obj.DoClick();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestNullable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport obj = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
			System.Nullable<UnityEngine.Vector3> arg0 = ToLua.CheckNullable<UnityEngine.Vector3>(L, 2);
			System.Nullable<UnityEngine.Vector3> o = obj.TestNullable(arg0);
			ToLua.PusNullable(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_LessThanOrEqual(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TestExport arg0 = (TestExport)ToLua.CheckObject<TestExport>(L, 1);
			TestExport arg1 = (TestExport)ToLua.CheckObject<TestExport>(L, 2);
			bool o = arg0 >= arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_field(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			int ret = obj.field;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index field on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			System.Action ret = obj.OnClick;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index OnClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnRefEvent(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			TestExport.TestRefEvent ret = obj.OnRefEvent;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index OnRefEvent on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_buffer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			byte[] ret = obj.buffer;
			LuaDLL.tolua_pushlstring(L, ret, ret.Length);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index buffer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Number(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			int ret = obj.Number;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Number on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_field(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			obj.field = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index field on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			System.Action arg0 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 2);
			obj.OnClick = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index OnClick on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnRefEvent(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			TestExport.TestRefEvent arg0 = (TestExport.TestRefEvent)ToLua.CheckDelegate<TestExport.TestRefEvent>(L, 2);
			obj.OnRefEvent = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index OnRefEvent on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_buffer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
			obj.buffer = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index buffer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Number(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TestExport obj = (TestExport)o;
			int arg0 = (int)LuaDLL.luaL_checkinteger(L, 2);
			obj.Number = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Number on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestExport_TestBuffer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<TestExport.TestBuffer>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<TestExport.TestBuffer>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestExport_TestRefEvent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<TestExport.TestRefEvent>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<TestExport.TestRefEvent>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

