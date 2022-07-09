---@class ProcedureMain:ProcedureBase
ProcedureMain = Class("ProcedureMain",ProcedureBase)
function ProcedureMain:OnEnter(csProcedure)
    self.super.OnEnter(self,csProcedure)
    Logger.Debug("进入了ProcedureMain OnEnter方法")
    self:OnChangeProcedure(ProcedureConfig.ProcedureLogin)
end
return ProcedureMain