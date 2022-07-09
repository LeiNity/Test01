
---================================================
---描 述 :  所有lua单利东西写这里统一调用
---作 者 : 杜鑫
---创建时间 : 2021-07-12 00-05-08 
---修改作者 : 杜鑫
---修改时间 : 2021-07-12 00-05-08 
---版 本 : 0.1
---===============================================
---@class LuaGameEntry
LuaGameEntry = {}

---@return LuaProcedureComponent
function LuaGameEntry:GetProcedureComponent()
    return LuaProcedureComponent:GetInstance()
end

---@return LuaEventComponent
function LuaGameEntry:GetLuaEventComponent()
    return LuaEventComponent:GetInstance()
end

---@return LuaSoundComponent
function LuaGameEntry:GetLuaSoundComponent()
    return LuaSoundComponent:GetInstance()
end

---@return LuaUIComponent
function LuaGameEntry:GetUIComponent()
    return LuaUIComponent:GetInstance()
end

LuaGameEntry.Procedure = LuaGameEntry:GetProcedureComponent()
LuaGameEntry.LuaEvent = LuaGameEntry:GetLuaEventComponent()
LuaGameEntry.LuaSound = LuaGameEntry:GetLuaSoundComponent()
LuaGameEntry.UI = LuaGameEntry:GetUIComponent()

function LuaGameEntry:Cleanup()
    LuaGameEntry.Procedure:Delete()
    LuaGameEntry.LuaEvent:Delete()
end

return LuaGameEntry