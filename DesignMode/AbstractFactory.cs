using System;
using System.Collections.Generic;
using System.Text;

//==============================================================
//  Copyright (C) 2020 Jeteam Inc. All rights reserved.
//  抽象工厂:通过创建一个产品的接口来创建具体的类，而不明确指定那个类
//  优点：对同一系列产品的变化支持扩展封闭原则
//  缺点：对产品的增加减少不支持封闭扩展原则
//  使用前提：1、一个系统不要求依赖产品如何被创建，组合和表达的表达，这也是
//             所有工厂实现的前提
//          2、这个系统有多个系列的产品，而消费者只消费其中一个
//          3、系统要求提供一个产品类库，所有产品以同一个接口实现，客户端不
//            需要依赖具体实现
//==============================================================
//  Create by qccoder
//  Create Time 2020/6/8 14:54:13.
//  Version 1.0
//==============================================================
namespace DesignMode.AbstractFactory
{
    /// <summary>
    /// 抽象工厂基类:提供产品创建接口
    /// </summary>
    public abstract class AbstractFactory
    {
        //创建产品A
        public abstract ProductA CreateProductA();
        //创建产品B
        public abstract ProductB CreateProductB();
    }
    /// <summary>
    /// 中国工厂生成产品
    /// </summary>
    public class ChineseFactory : AbstractFactory
    {
        public override ProductA CreateProductA()
        {
            return new ChineseProductA();
        }

        public override ProductB CreateProductB()
        {
            return new ChineseProductB();
        }
    }
    public class UKFactory : AbstractFactory
    {
        public override ProductA CreateProductA()
        {
            return new UKProductA();
        }

        public override ProductB CreateProductB()
        {
            return new UKProductB();
        }
    }
    /// <summary>
    /// 抽象产品基类
    /// </summary>
    public abstract class Product
    {
        public string productName;
    }
    /// <summary>
    /// 抽象产品A
    /// </summary>
    public abstract class ProductA : Product
    {
        public abstract ProductA CreateProductA();
    }
    /// <summary>
    /// 抽象产品B
    /// </summary>
    public abstract class ProductB : Product
    {
        public abstract ProductB CreateProductB();
    }
    /// <summary>
    /// 中国产的产品A
    /// </summary>
    public class ChineseProductA : ProductA
    {
        public override ProductA CreateProductA()
        {
            Console.WriteLine("中国产的产品A");
            return this;
        }
    }
    /// <summary>
    /// 中国产的产品B
    /// </summary>
    public class ChineseProductB : ProductB
    {
        public override ProductB CreateProductB()
        {
            Console.WriteLine("中国产的产品B");
            return this;
        }
    }
    /// <summary>
    /// 英国产的产品A
    /// </summary>
    public class UKProductA : ProductA
    {
        public override ProductA CreateProductA()
        {
            Console.WriteLine("英国产的产品A");
            return this;
        }
    }
    public class UKProductB : ProductB
    {
        public override ProductB CreateProductB()
        {
            Console.WriteLine("英国产的产品B");
            return this;
        }
    }

}
