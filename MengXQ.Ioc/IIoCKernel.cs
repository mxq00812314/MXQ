using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MengXQ.Ioc
{

    /*
     * 
     * 核心功能：生成依赖注入过程中的上层对象
        基础流程：
        1.需要向IoC容器中注册依赖注入过程中抽象、具体。
        2.在使用IoC的时候需向IoC中注册上层对象的类型。
        3.解析上层对象类型，并且执行生成对象操作
        4.返回上层对象实例


        功能对象定义：
        1.抽象、具体关系维护的对象，用以维护依赖注入过程中抽象、具体的对应关系。
        2.解析对象类型的对象，根据依赖注入的几种方式分析对象类型的构造和公共属性并且生成，（公共属性是符合IoC框架中定义的标准）。
        3.公共属性标准对象，用以通知IoC框架上层对象中哪些公共属性需要被注入。
        4.执行过程对象，用以表示框架执行流程，框架入口点。
        初步就这样定了，有可能下面定义的类型中上面没有定义到，但是不妨碍，知道基础流程就行了。那现在就开始吧。
     * 
     */

    public interface IIoCKernel
    {
        IIoCKernel Bind<T>();
        IIoCKernel To<U>() where U : class;
        V GetValue<V>() where V : class;
    }
}
