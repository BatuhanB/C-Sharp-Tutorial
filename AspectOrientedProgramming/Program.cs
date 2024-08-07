﻿#region Dynamic Proxy

using AspectOrientedProgramming.CastleDynamicProxy;
using Castle.DynamicProxy;

var proxy = new ProxyGenerator();
var aspect = proxy.CreateClassProxy<MyClass>(new MyInterceptorAspect());
aspect.MyMethod();
Console.ReadLine();

#endregion

#region Get Proxy Properties

//using AspectOrientedProgramming.Entities;
//using AspectOrientedProgramming.InterceptionAspect;
//using Castle.DynamicProxy;

//var proxy = new ProxyGenerator();
//var aspect1 = proxy.CreateClassProxy<Employee>(new MyInterceptionAspect());
////aspect1.Add(1, "Batuhan");
////aspect1.Add();

//var aspect2 = proxy.CreateClassProxy<Employee>(
//        new MyInterceptionAspect(),
//        new DefensiveProgramming());

//var employee = new Employee()
//{
//    Id = 1,
//    Name = "Test",
//};
//aspect2.Update(employee.Id, employee.Name);

//Console.ReadLine();
#endregion

#region Attribute

//using AspectOrientedProgramming.CastleDynamicProxy;
//using AspectOrientedProgramming.Core.Interceptors;
//using Autofac;
//using Autofac.Extras.DynamicProxy;
//using Castle.DynamicProxy;

//var builder = new ContainerBuilder();
//builder.RegisterType<MyClass>().As<IMyClass>().EnableInterfaceInterceptors(new ProxyGenerationOptions()
//{
//    Selector = new AspectInterceptorSelector()
//}).SingleInstance();

//var container = builder.Build();
//var intercepted = container.Resolve<IMyClass>();
//intercepted.MyMethod();
#endregion