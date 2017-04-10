// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\FranchiserView.json"
// Version: 1004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
#pragma warning disable 0108
#pragma warning disable 1591

namespace Noman {
using __FrCompanyT1__ = global::Noman.FranchiserView.CompanyTrendValuesElementJson.JsonByExample;
using __FrHouseSol__ = global::Noman.FranchiserView.HouseSoldValuesElementJson;
using __FHoSchema__ = global::Noman.FranchiserView.HouseSoldValuesElementJson.JsonByExample.Schema;
using __FrHouseSol1__ = global::Noman.FranchiserView.HouseSoldValuesElementJson.JsonByExample;
using __FrHouseSol2__ = global::Noman.FranchiserView.HouseSoldValuesElementJson.Input;
using __TArray4__ = global::Starcounter.Templates.TArray<global::Noman.FranchiserView.HouseSoldValuesElementJson>;
using __TLong__ = global::Starcounter.Templates.TLong;
using __Franchis1__ = global::Noman.FranchiserView.JsonByExample;
using __Arr1__ = global::Starcounter.Arr<global::Noman.FranchiserView.AverageCommisionValuesElementJson>;
using __Arr2__ = global::Starcounter.Arr<global::Noman.FranchiserView.TotalCommisionValuesElementJson>;
using __Arr3__ = global::Starcounter.Arr<global::Noman.FranchiserView.CompanyTrendValuesElementJson>;
using __Arr4__ = global::Starcounter.Arr<global::Noman.FranchiserView.HouseSoldValuesElementJson>;
using __Franchis2__ = global::Noman.FranchiserView.Input;
using __FrHtml__ = global::Noman.FranchiserView.Input.Html;
using __FrName__ = global::Noman.FranchiserView.Input.Name;
using __FrCreateNe__ = global::Noman.FranchiserView.Input.CreateNewFranchiseeCompany;
using __FrSaveFran__ = global::Noman.FranchiserView.Input.SaveFranchiseAgencyInfo;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __TArray3__ = global::Starcounter.Templates.TArray<global::Noman.FranchiserView.CompanyTrendValuesElementJson>;
using __FrCompanyT2__ = global::Noman.FranchiserView.CompanyTrendValuesElementJson.Input;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __FCoSchema__ = global::Noman.FranchiserView.CompanyTrendValuesElementJson.JsonByExample.Schema;
using __Franchis__ = global::Noman.FranchiserView;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __FrSchema__ = global::Noman.FranchiserView.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;
using __FrAverageC__ = global::Noman.FranchiserView.AverageCommisionValuesElementJson;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __FrAverageC1__ = global::Noman.FranchiserView.AverageCommisionValuesElementJson.JsonByExample;
using __FrAverageC2__ = global::Noman.FranchiserView.AverageCommisionValuesElementJson.Input;
using __TArray1__ = global::Starcounter.Templates.TArray<global::Noman.FranchiserView.AverageCommisionValuesElementJson>;
using __FrTotalCom__ = global::Noman.FranchiserView.TotalCommisionValuesElementJson;
using __FToSchema__ = global::Noman.FranchiserView.TotalCommisionValuesElementJson.JsonByExample.Schema;
using __FrTotalCom1__ = global::Noman.FranchiserView.TotalCommisionValuesElementJson.JsonByExample;
using __FrTotalCom2__ = global::Noman.FranchiserView.TotalCommisionValuesElementJson.Input;
using __TArray2__ = global::Starcounter.Templates.TArray<global::Noman.FranchiserView.TotalCommisionValuesElementJson>;
using __FrCompanyT__ = global::Noman.FranchiserView.CompanyTrendValuesElementJson;
using __FAvSchema__ = global::Noman.FranchiserView.AverageCommisionValuesElementJson.JsonByExample.Schema;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiserView_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class FranchiserView : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiserView() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiserView(__FrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FrSchema__ Template { get { return (__FrSchema__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new MainFranchiser Data { get { return (MainFranchiser)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Franchis__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Noman/FranchiserView.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Companies = Add<__TArray__>("Companies");
                Companies.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Companies__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Companies__ = (__Arr__)_v_; }, false);
                AverageCommisionValues = Add<__TArray1__>("AverageCommisionValues");
                AverageCommisionValues.SetCustomGetElementType((arr) => { return __FrAverageC__.DefaultTemplate;});
                AverageCommisionValues.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__AverageCommisionValues__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__AverageCommisionValues__ = (__Arr1__)_v_; }, false);
                TotalCommisionValues = Add<__TArray2__>("TotalCommisionValues");
                TotalCommisionValues.SetCustomGetElementType((arr) => { return __FrTotalCom__.DefaultTemplate;});
                TotalCommisionValues.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__TotalCommisionValues__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__TotalCommisionValues__ = (__Arr2__)_v_; }, false);
                CompanyTrendValues = Add<__TArray3__>("CompanyTrendValues");
                CompanyTrendValues.SetCustomGetElementType((arr) => { return __FrCompanyT__.DefaultTemplate;});
                CompanyTrendValues.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__CompanyTrendValues__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__CompanyTrendValues__ = (__Arr3__)_v_; }, false);
                HouseSoldValues = Add<__TArray4__>("HouseSoldValues");
                HouseSoldValues.SetCustomGetElementType((arr) => { return __FrHouseSol__.DefaultTemplate;});
                HouseSoldValues.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__HouseSoldValues__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__HouseSoldValues__ = (__Arr4__)_v_; }, false);
                CreateNewFranchiseeCompany = Add<__TLong__>("CreateNewFranchiseeCompany$");
                CreateNewFranchiseeCompany.DefaultValue = 0L;
                CreateNewFranchiseeCompany.Editable = true;
                CreateNewFranchiseeCompany.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__CreateNewFranchiseeCompany__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__CreateNewFranchiseeCompany__ = (System.Int64)_v_; }, false);
                CreateNewFranchiseeCompany.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.CreateNewFranchiseeCompany() { App = (FranchiserView)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiserView)pup).Handle((Input.CreateNewFranchiseeCompany)input); });
                SaveFranchiseAgencyInfo = Add<__TLong__>("SaveFranchiseAgencyInfo$");
                SaveFranchiseAgencyInfo.DefaultValue = 0L;
                SaveFranchiseAgencyInfo.Editable = true;
                SaveFranchiseAgencyInfo.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SaveFranchiseAgencyInfo__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SaveFranchiseAgencyInfo__ = (System.Int64)_v_; }, false);
                SaveFranchiseAgencyInfo.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveFranchiseAgencyInfo() { App = (FranchiserView)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiserView)pup).Handle((Input.SaveFranchiseAgencyInfo)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TArray__ Companies;
            public __TArray1__ AverageCommisionValues;
            public __TArray2__ TotalCommisionValues;
            public __TArray3__ CompanyTrendValues;
            public __TArray4__ HouseSoldValues;
            public __TLong__ CreateNewFranchiseeCompany;
            public __TLong__ SaveFranchiseAgencyInfo;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 3 "ViewModels\FranchiserView.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 3 "ViewModels\FranchiserView.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 4 "ViewModels\FranchiserView.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 4 "ViewModels\FranchiserView.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Companies__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Companies {
    #line 5 "ViewModels\FranchiserView.json"
        get {
        #line hidden
            return Template.Companies.Getter(this); }
        #line 5 "ViewModels\FranchiserView.json"
        set {
        #line hidden
            Template.Companies.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr1__ __bf__AverageCommisionValues__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr1__ AverageCommisionValues {
    #line 7 "ViewModels\FranchiserView.json"
        get {
        #line hidden
            return Template.AverageCommisionValues.Getter(this); }
        #line 7 "ViewModels\FranchiserView.json"
        set {
        #line hidden
            Template.AverageCommisionValues.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr2__ __bf__TotalCommisionValues__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr2__ TotalCommisionValues {
    #line 8 "ViewModels\FranchiserView.json"
        get {
        #line hidden
            return Template.TotalCommisionValues.Getter(this); }
        #line 8 "ViewModels\FranchiserView.json"
        set {
        #line hidden
            Template.TotalCommisionValues.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr3__ __bf__CompanyTrendValues__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr3__ CompanyTrendValues {
    #line 9 "ViewModels\FranchiserView.json"
        get {
        #line hidden
            return Template.CompanyTrendValues.Getter(this); }
        #line 9 "ViewModels\FranchiserView.json"
        set {
        #line hidden
            Template.CompanyTrendValues.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr4__ __bf__HouseSoldValues__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr4__ HouseSoldValues {
    #line 10 "ViewModels\FranchiserView.json"
        get {
        #line hidden
            return Template.HouseSoldValues.Getter(this); }
        #line 10 "ViewModels\FranchiserView.json"
        set {
        #line hidden
            Template.HouseSoldValues.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__CreateNewFranchiseeCompany__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CreateNewFranchiseeCompany {
    #line 11 "ViewModels\FranchiserView.json"
        get {
        #line hidden
            return Template.CreateNewFranchiseeCompany.Getter(this); }
        #line 11 "ViewModels\FranchiserView.json"
        set {
        #line hidden
            Template.CreateNewFranchiseeCompany.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveFranchiseAgencyInfo__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveFranchiseAgencyInfo {
    #line 12 "ViewModels\FranchiserView.json"
        get {
        #line hidden
            return Template.SaveFranchiseAgencyInfo.Getter(this); }
        #line 12 "ViewModels\FranchiserView.json"
        set {
        #line hidden
            Template.SaveFranchiseAgencyInfo.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class AverageCommisionValuesElementJson : __Arr__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __FAvSchema__ DefaultTemplate = new __FAvSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public AverageCommisionValuesElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public AverageCommisionValuesElementJson(__FAvSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __FAvSchema__ Template { get { return (__FAvSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TArray__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__FrAverageC__);
                }
                public override object CreateInstance(s.Json parent) { return new __FrAverageC__(this) { Parent = parent }; }
            }
            #line default
        }
        #line default
        
        #line hidden
        public static class Input {
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class TotalCommisionValuesElementJson : __Arr__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __FToSchema__ DefaultTemplate = new __FToSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public TotalCommisionValuesElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public TotalCommisionValuesElementJson(__FToSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __FToSchema__ Template { get { return (__FToSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TArray__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__FrTotalCom__);
                }
                public override object CreateInstance(s.Json parent) { return new __FrTotalCom__(this) { Parent = parent }; }
            }
            #line default
        }
        #line default
        
        #line hidden
        public static class Input {
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class CompanyTrendValuesElementJson : __Arr__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __FCoSchema__ DefaultTemplate = new __FCoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CompanyTrendValuesElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CompanyTrendValuesElementJson(__FCoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __FCoSchema__ Template { get { return (__FCoSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TArray__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__FrCompanyT__);
                }
                public override object CreateInstance(s.Json parent) { return new __FrCompanyT__(this) { Parent = parent }; }
            }
            #line default
        }
        #line default
        
        #line hidden
        public static class Input {
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class HouseSoldValuesElementJson : __Arr__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __FHoSchema__ DefaultTemplate = new __FHoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public HouseSoldValuesElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public HouseSoldValuesElementJson(__FHoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __FHoSchema__ Template { get { return (__FHoSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TArray__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__FrHouseSol__);
                }
                public override object CreateInstance(s.Json parent) { return new __FrHouseSol__(this) { Parent = parent }; }
            }
            #line default
        }
        #line default
        
        #line hidden
        public static class Input {
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CreateNewFranchiseeCompany : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SaveFranchiseAgencyInfo : Input<__Franchis__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
