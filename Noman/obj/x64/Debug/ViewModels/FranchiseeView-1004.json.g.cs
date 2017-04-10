// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\FranchiseeView.json"
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
using __FrName__ = global::Noman.FranchiseeView.Input.Name;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __FrSaveCurr__ = global::Noman.FranchiseeView.Input.SaveCurrentFranchiseeInfo;
using __FrCreateNe__ = global::Noman.FranchiseeView.Input.CreateNewHouse;
using __Frurl__ = global::Noman.FranchiseeView.Input.url;
using __FrComplete__ = global::Noman.FranchiseeView.Input.CompleteAddress;
using __FrCountry__ = global::Noman.FranchiseeView.Input.Country;
using __FrState__ = global::Noman.FranchiseeView.Input.State;
using __FrCity__ = global::Noman.FranchiseeView.Input.City;
using __FrZipCode__ = global::Noman.FranchiseeView.Input.ZipCode;
using __FrStreet__ = global::Noman.FranchiseeView.Input.Street;
using __FrHouse_No__ = global::Noman.FranchiseeView.Input.House_No;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __FrHtml__ = global::Noman.FranchiseeView.Input.Html;
using __Franchis2__ = global::Noman.FranchiseeView.Input;
using __Arr__ = global::Starcounter.Arr<global::Starcounter.Json>;
using __Franchis1__ = global::Noman.FranchiseeView.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TArray__ = global::Starcounter.Templates.TArray<global::Starcounter.Json>;
using __TString__ = global::Starcounter.Templates.TString;
using __FrSchema__ = global::Noman.FranchiseeView.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Franchis__ = global::Noman.FranchiseeView;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseeView_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class FranchiseeView : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseeView() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseeView(__FrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FrSchema__ Template { get { return (__FrSchema__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new Franchisee Data { get { return (Franchisee)base.Data; } set { base.Data = value; } }
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
                Html.DefaultValue = "/Noman/FranchiseeView.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Houses = Add<__TArray__>("Houses");
                Houses.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Houses__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Houses__ = (__Arr__)_v_; }, false);
                House_No = Add<__TString__>("House_No$");
                House_No.DefaultValue = "";
                House_No.Editable = true;
                House_No.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__House_No__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__House_No__ = (System.String)_v_; }, false);
                Street = Add<__TString__>("Street$");
                Street.DefaultValue = "";
                Street.Editable = true;
                Street.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                ZipCode = Add<__TString__>("ZipCode$");
                ZipCode.DefaultValue = "";
                ZipCode.Editable = true;
                ZipCode.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__ZipCode__ = (System.String)_v_; }, false);
                City = Add<__TString__>("City$");
                City.DefaultValue = "";
                City.Editable = true;
                City.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__City__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__City__ = (System.String)_v_; }, false);
                State = Add<__TString__>("State$");
                State.DefaultValue = "";
                State.Editable = true;
                State.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__State__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__State__ = (System.String)_v_; }, false);
                Country = Add<__TString__>("Country$");
                Country.DefaultValue = "";
                Country.Editable = true;
                Country.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                CompleteAddress = Add<__TString__>("CompleteAddress", bind:"CompleteAddress");
                CompleteAddress.DefaultValue = "";
                CompleteAddress.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__CompleteAddress__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__CompleteAddress__ = (System.String)_v_; }, false);
                url = Add<__TString__>("url", bind:"url");
                url.DefaultValue = "";
                url.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__url__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__url__ = (System.String)_v_; }, false);
                CreateNewHouse = Add<__TLong__>("CreateNewHouse$");
                CreateNewHouse.DefaultValue = 0L;
                CreateNewHouse.Editable = true;
                CreateNewHouse.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__CreateNewHouse__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__CreateNewHouse__ = (System.Int64)_v_; }, false);
                CreateNewHouse.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.CreateNewHouse() { App = (FranchiseeView)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseeView)pup).Handle((Input.CreateNewHouse)input); });
                SaveCurrentFranchiseeInfo = Add<__TLong__>("SaveCurrentFranchiseeInfo$");
                SaveCurrentFranchiseeInfo.DefaultValue = 0L;
                SaveCurrentFranchiseeInfo.Editable = true;
                SaveCurrentFranchiseeInfo.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SaveCurrentFranchiseeInfo__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SaveCurrentFranchiseeInfo__ = (System.Int64)_v_; }, false);
                SaveCurrentFranchiseeInfo.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveCurrentFranchiseeInfo() { App = (FranchiseeView)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseeView)pup).Handle((Input.SaveCurrentFranchiseeInfo)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TArray__ Houses;
            public __TString__ House_No;
            public __TString__ Street;
            public __TString__ ZipCode;
            public __TString__ City;
            public __TString__ State;
            public __TString__ Country;
            public __TString__ CompleteAddress;
            public __TString__ url;
            public __TLong__ CreateNewHouse;
            public __TLong__ SaveCurrentFranchiseeInfo;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModels\FranchiseeView.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModels\FranchiseeView.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "ViewModels\FranchiseeView.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "ViewModels\FranchiseeView.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Houses__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Houses {
    #line 4 "ViewModels\FranchiseeView.json"
        get {
        #line hidden
            return Template.Houses.Getter(this); }
        #line 4 "ViewModels\FranchiseeView.json"
        set {
        #line hidden
            Template.Houses.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__House_No__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String House_No {
    #line 6 "ViewModels\FranchiseeView.json"
        get {
        #line hidden
            return Template.House_No.Getter(this); }
        #line 6 "ViewModels\FranchiseeView.json"
        set {
        #line hidden
            Template.House_No.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Street__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Street {
    #line 7 "ViewModels\FranchiseeView.json"
        get {
        #line hidden
            return Template.Street.Getter(this); }
        #line 7 "ViewModels\FranchiseeView.json"
        set {
        #line hidden
            Template.Street.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ZipCode {
    #line 8 "ViewModels\FranchiseeView.json"
        get {
        #line hidden
            return Template.ZipCode.Getter(this); }
        #line 8 "ViewModels\FranchiseeView.json"
        set {
        #line hidden
            Template.ZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__City__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String City {
    #line 9 "ViewModels\FranchiseeView.json"
        get {
        #line hidden
            return Template.City.Getter(this); }
        #line 9 "ViewModels\FranchiseeView.json"
        set {
        #line hidden
            Template.City.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__State__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String State {
    #line 10 "ViewModels\FranchiseeView.json"
        get {
        #line hidden
            return Template.State.Getter(this); }
        #line 10 "ViewModels\FranchiseeView.json"
        set {
        #line hidden
            Template.State.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Country__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Country {
    #line 11 "ViewModels\FranchiseeView.json"
        get {
        #line hidden
            return Template.Country.Getter(this); }
        #line 11 "ViewModels\FranchiseeView.json"
        set {
        #line hidden
            Template.Country.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__CompleteAddress__;
    #line default
    #line hidden
    private System.String __bf__url__;
    #line default
    #line hidden
    private System.Int64 __bf__CreateNewHouse__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CreateNewHouse {
    #line 14 "ViewModels\FranchiseeView.json"
        get {
        #line hidden
            return Template.CreateNewHouse.Getter(this); }
        #line 14 "ViewModels\FranchiseeView.json"
        set {
        #line hidden
            Template.CreateNewHouse.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveCurrentFranchiseeInfo__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveCurrentFranchiseeInfo {
    #line 15 "ViewModels\FranchiseeView.json"
        get {
        #line hidden
            return Template.SaveCurrentFranchiseeInfo.Getter(this); }
        #line 15 "ViewModels\FranchiseeView.json"
        set {
        #line hidden
            Template.SaveCurrentFranchiseeInfo.Setter(this, value); } }
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
        public class House_No : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Street : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ZipCode : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class City : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class State : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Country : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CompleteAddress : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class url : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CreateNewHouse : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SaveCurrentFranchiseeInfo : Input<__Franchis__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
