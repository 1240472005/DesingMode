using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// 简单工厂模式
    /// 实现思路：把改变的代码用类来封装
    /// 优点：1、降低了耦合度，把使用者与产品的关系从直接关系变为间接关系，消除使用者和产品之间的直接创建关系，而仅仅是使用关系，实现了对责任的分割
    ///      2、实现了代码的复用
    /// 缺点：1、工厂类集中了所有产品的逻辑，一旦工厂类不能正常使用，整个系统都会受到影响
    ///      2、系统扩展困难，一旦添加了新的产品就要去修改逻辑代码
    ///应用场景：
    ///      1、当创建的对象类型较少的时候可以使用
    ///      2、当客户只知道传入的参数而不知道具体创建细节的时候
    /// </summary>
namespace DesignMode.SimpleFactory
{
    /// <summary>
    /// 产品基类
    /// </summary>
    public abstract class Product
    {
        public abstract void CreateProduct();
    }
    /// <summary>
    /// 产品A
    /// </summary>
    public class ProductA:Product
    {   
        public override void CreateProduct()
        {
            Console.WriteLine("产品A的创建");
        }
    }
    /// <summary>
    /// 产品B
    /// </summary>
    public class ProductB:Product
    {
        public override void CreateProduct()
        {
            Console.WriteLine("产品B的创建");
        }
    }
    /// <summary>
    /// 客户
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// 不运行当前程序的时候就注释掉
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    Product product = SimpleFactory.Create(1);
        //    product.CreateProduct();
        //    product = SimpleFactory.Create(2);
        //    product.CreateProduct();
        //}
    }
    /// <summary>
    /// 简单工厂
    /// </summary>
    public class SimpleFactory
    {
        
        public static Product Create(int id)
        {
            Product product=null;
            switch (id)
            {
                case 1:
                    product = new ProductA();
                    break;
                case 2:
                    product = new ProductB();
                    break;
            }
            return product;
        }
    }
}
