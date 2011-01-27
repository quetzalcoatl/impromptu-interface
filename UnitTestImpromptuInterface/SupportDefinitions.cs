// 
//  Copyright 2010  Ekon Benefits
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace UnitTestImpromptuInterface
{


    public interface ISimpeleClassProps
    {
        string Prop1 { get;  }

        long Prop2 { get; }

        Guid Prop3 { get; }
    }

    public interface ISimpleStringProperty
    {
        int Length { get; }

    }

    public interface ISimpleStringMethod
    {
        bool StartsWith(string value);

    }

    public interface ISimpeleClassMeth
    {
        void Action1();
        void Action2(bool value);
        string Action3();
    }

    public interface IGenericMeth
    {
        string Action<T>(T arg);

        T Action2<T>(T arg);
    }

	
	 public interface IGenericMethWithConstraints
    {
        string Action<T>(T arg) where T:class;
        string Action2<T>(T arg) where T : ISerializable;
    }
	
	 public interface IGenericType<T>
    {
		string Funct(T arg);
		
     
    }

     public interface IGenericTypeConstraints<T> where T:class
     {
         string Funct(T arg);

     }


    public interface IOverloadingMethod
    {
       string Func(int arg);

       string Func(object arg);
    }

    public class OverloadingMethPoco
    {
        public string Func(int arg)
        {
            return "int";
        }

        public string Func(object arg)
        {
            return "object";
        }
    }

    /// <summary>
    /// Dynamic Delegates need to return object or void, first parameter should be a CallSite, second object, followed by the expected arguments
    /// </summary>
    public delegate object DynamicTryString(CallSite callsite, object target, out string result);

    public class MethOutPoco
    {
        public bool Func(out string result)
        {
            result = "success";
            return true;
        }


    
    }
    public class GenericMethOutPoco
    {
        public bool Func<T>(out T result)
        {
            result = default(T);
            return true;
        }
    }

    public interface IGenericMethodOut
    {
        bool Func<T>(out T result);
    }

    public interface IMethodOut2
    {
        bool Func(out int result);
    }


    public interface IMethodOut
    {
        bool Func(out string result);
    }

    public class MethRefPoco
    {
        public bool Func(ref int result)
        {
            result = result + 2;
            return true;
        }


        public void test()
        {
            dynamic tMethod = new MethRefPoco();
            var tResult = 1;
            bool tbool = tMethod.Func(ref tResult);
        }
    }

    public interface IMethodRef
    {
        bool Func(ref int result);
    }
}
