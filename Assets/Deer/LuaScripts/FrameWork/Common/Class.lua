
---================================================
---描 述 :
---作 者 : 杜鑫
---创建时间 : 2021-10-30 23-47-19 
---修改作者 : 杜鑫
---修改时间 : 2021-10-30 23-47-19 
---版 本 : 0.1
---===============================================

---保存类类型的虚表
local classTemp = {}
-- added by wsh @ 2017-12-09
-- 自定义类型
local ClassType = {
    class = 1,
    instance = 2,
}
function SetMetaTableIndex(t, index)
    if t == nil or index == nil then
        ---error
        return
    end
    local mt = getmetatable(t)
    if not mt then
        mt = {}
    end
    if not mt.__index then
        mt.__index = index
        setmetatable(t, mt)
    elseif mt.__index ~= index then
        SetMetaTableIndex(mt, index)
    end
end

---@class Class
--[[---@field New function
---@field Delete function
---@field __init function
---@field __delete function]]
function Class(classname, super)
    assert(type(classname) == "string" and #classname > 0)
    -- 生成一个类类型
    local class_type = {}

    -- 在创建对象的时候自动调用
    class_type.__init = false
    class_type.__delete = false
    class_type.__cname = classname
    class_type.__ctype = ClassType.class

    class_type.super = super
    class_type.New = function(...)
        -- 生成一个类对象
        local obj = DeepCopy(class_type)
        obj._class_type = class_type
        obj.__ctype = ClassType.instance
        -- 在初始化之前注册基类方法
        setmetatable(obj, {
            __index = classTemp[class_type],
        })
        -- 调用初始化方法
        do
            local create
            create = function(c, ...)
                if c.super then
                    create(c.super, ...)
                end
                if c.__init then
                    c.__init(obj, ...)
                end
            end

            create(class_type, ...)
        end

        -- 注册一个delete方法
        obj.Delete = function(self)
            local now_super = self
            while now_super ~= nil do
                if now_super.__delete then
                    now_super.__delete(self)
                end
                now_super = now_super.super
            end
        end

        return obj
    end

    local vtbl = {}
    classTemp[class_type] = vtbl

    setmetatable(class_type, {
        __newindex = function(t, k, v)
            vtbl[k] = v
        end
    ,
        --For call parent method
        __index = vtbl,
    })

    if super then
        setmetatable(vtbl, {
            __index = function(t, k)
                local ret = classTemp[super][k]
                --do not do accept, make hot update work right!
                --vtbl[k] = ret
                return ret
            end
        })
    end
    return class_type
end

