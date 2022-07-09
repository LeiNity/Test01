--主入口函数。从这里开始lua逻辑
require "FrameWork.Require.RequireTable"
GameObject = UnityEngine.GameObject
function Main()
    print("启动Main函数--------->")
    print(string.format("屏幕分辨率：%s * %s",UnityEngine.Screen.width,UnityEngine.Screen.height))
end