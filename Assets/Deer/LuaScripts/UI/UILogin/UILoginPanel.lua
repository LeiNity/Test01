
---================================================
---描 述 : 
---作 者 : Admin 
---创建时间 : 2021-08-01 21-18-50 
---修改作者 : Admin 
---修改时间 : 2021-08-01 21-18-50 
---版 本 : $Version 
---===============================================
UILoginPanel = UILoginPanel --Assets/Deer/Asset/UI/UIPrefab/UILogin/UILoginPanel.prefab
---@class UILoginPanel:UIBaseClass
--------------AutoGenerated--------------
---@field loginBtn UIButtonSuper
---@field passWordInputField UnityEngine.UI.InputField
---@field userNameInputField UnityEngine.UI.InputField
--------------Do not modify!-------------
local UILoginPanel = Class('UILoginPanel', UIBaseClass)


function UILoginPanel:OnShow()
    self.super.OnShow(self)

end




function UILoginPanel:OnHide()
    self.super.OnHide(self)
    self:UnRegisterEvent()
end

function UILoginPanel:RegisterEvent()

end

function UILoginPanel:UnRegisterEvent()

end

function UILoginPanel:Update(param1,param2)
end
-----------------------------logic----------------------------------

-----------------------------event----------------------------------
function UILoginPanel:testDelay()
end
-----------------------------button----------------------------------
---@param button UIButtonSuper
function UILoginPanel:OnClickLoginBtnBtn(button)
    --LuaGameEntry.LuaEvent:SendCSEvent(EventId.EVENT_LUA_SEND_SOCKET_REQUEST,{1,2})
    --LuaGameEntry.NetWork:UnRegisterLuaEvent()
    LuaGameEntry.Procedure:OnChangeLuaProcedure(ProcedureConfig.ProcedureMainHall)
    LuaGameEntry.UI:CloseUI(UINameConfig.UILoginPanel)
end

---@param button UIButtonSuper
function UILoginPanel:OnDoubleClickLoginBtnBtn(button)

end

---@param button UIButtonSuper
function UILoginPanel:OnLongPressLoginBtnBtn(button)

end

return UILoginPanel
