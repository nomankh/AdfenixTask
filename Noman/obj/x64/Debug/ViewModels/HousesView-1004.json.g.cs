// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\HousesView.json"
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
using __HoCity__ = global::Noman.HousesView.Input.City;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __HoRegister__ = global::Noman.HousesView.Input.RegisterHouse;
using __Holongitud__ = global::Noman.HousesView.Input.longitude;
using __Holatitude__ = global::Noman.HousesView.Input.latitude;
using __HoLatitude__ = global::Noman.HousesView.Input.Latitude;
using __HoLongitud__ = global::Noman.HousesView.Input.Longitude;
using __HoComplete__ = global::Noman.HousesView.Input.CompleteAddress;
using __HoCommisio__ = global::Noman.HousesView.Input.Commision;
using __HoSalePric__ = global::Noman.HousesView.Input.SalePrice;
using __HoTransact__ = global::Noman.HousesView.Input.TransactionTime;
using __HoCountry__ = global::Noman.HousesView.Input.Country;
using __HoState__ = global::Noman.HousesView.Input.State;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __HoStreet__ = global::Noman.HousesView.Input.Street;
using __HoHouse_No__ = global::Noman.HousesView.Input.House_No;
using __Hourl__ = global::Noman.HousesView.Input.url;
using __HoHtml__ = global::Noman.HousesView.Input.Html;
using __HousesVi2__ = global::Noman.HousesView.Input;
using __HousesVi1__ = global::Noman.HousesView.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __HoSchema__ = global::Noman.HousesView.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __HousesVi__ = global::Noman.HousesView;
using __HoZipCode__ = global::Noman.HousesView.Input.ZipCode;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class HousesView_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class HousesView : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __HoSchema__ DefaultTemplate = new __HoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public HousesView() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public HousesView(__HoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __HoSchema__ Template { get { return (__HoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__HousesVi__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/Noman/HousesView.html";
                Html.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                url = Add<__TString__>("url", bind:"url");
                url.DefaultValue = "";
                url.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__url__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__url__ = (System.String)_v_; }, false);
                House_No = Add<__TString__>("House_No$");
                House_No.DefaultValue = "";
                House_No.Editable = true;
                House_No.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__House_No__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__House_No__ = (System.String)_v_; }, false);
                Street = Add<__TString__>("Street$");
                Street.DefaultValue = "";
                Street.Editable = true;
                Street.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                ZipCode = Add<__TString__>("ZipCode$");
                ZipCode.DefaultValue = "";
                ZipCode.Editable = true;
                ZipCode.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__ZipCode__ = (System.String)_v_; }, false);
                City = Add<__TString__>("City$");
                City.DefaultValue = "";
                City.Editable = true;
                City.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__City__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__City__ = (System.String)_v_; }, false);
                State = Add<__TString__>("State$");
                State.DefaultValue = "";
                State.Editable = true;
                State.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__State__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__State__ = (System.String)_v_; }, false);
                Country = Add<__TString__>("Country$");
                Country.DefaultValue = "";
                Country.Editable = true;
                Country.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                TransactionTime = Add<__TString__>("TransactionTime$");
                TransactionTime.DefaultValue = "";
                TransactionTime.Editable = true;
                TransactionTime.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__TransactionTime__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__TransactionTime__ = (System.String)_v_; }, false);
                SalePrice = Add<__TLong__>("SalePrice$");
                SalePrice.DefaultValue = 0L;
                SalePrice.Editable = true;
                SalePrice.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__SalePrice__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__SalePrice__ = (System.Int64)_v_; }, false);
                Commision = Add<__TLong__>("Commision$");
                Commision.DefaultValue = 0L;
                Commision.Editable = true;
                Commision.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__Commision__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__Commision__ = (System.Int64)_v_; }, false);
                CompleteAddress = Add<__TString__>("CompleteAddress", bind:"CompleteAddress");
                CompleteAddress.DefaultValue = "";
                CompleteAddress.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__CompleteAddress__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__CompleteAddress__ = (System.String)_v_; }, false);
                Longitude = Add<__TString__>("Longitude$");
                Longitude.DefaultValue = "";
                Longitude.Editable = true;
                Longitude.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__Longitude__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__Longitude__ = (System.String)_v_; }, false);
                Latitude = Add<__TString__>("Latitude$");
                Latitude.DefaultValue = "";
                Latitude.Editable = true;
                Latitude.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__Latitude__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__Latitude__ = (System.String)_v_; }, false);
                latitude = Add<__TLong__>("latitude", bind:"latitude");
                latitude.DefaultValue = 0L;
                latitude.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__latitude__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__latitude__ = (System.Int64)_v_; }, false);
                longitude = Add<__TLong__>("longitude", bind:"longitude");
                longitude.DefaultValue = 0L;
                longitude.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__longitude__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__longitude__ = (System.Int64)_v_; }, false);
                RegisterHouse = Add<__TLong__>("RegisterHouse$");
                RegisterHouse.DefaultValue = 0L;
                RegisterHouse.Editable = true;
                RegisterHouse.SetCustomAccessors((_p_) => { return ((__HousesVi__)_p_).__bf__RegisterHouse__; }, (_p_, _v_) => { ((__HousesVi__)_p_).__bf__RegisterHouse__ = (System.Int64)_v_; }, false);
                RegisterHouse.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.RegisterHouse() { App = (HousesView)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((HousesView)pup).Handle((Input.RegisterHouse)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __HousesVi__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ url;
            public __TString__ House_No;
            public __TString__ Street;
            public __TString__ ZipCode;
            public __TString__ City;
            public __TString__ State;
            public __TString__ Country;
            public __TString__ TransactionTime;
            public __TLong__ SalePrice;
            public __TLong__ Commision;
            public __TString__ CompleteAddress;
            public __TString__ Longitude;
            public __TString__ Latitude;
            public __TLong__ latitude;
            public __TLong__ longitude;
            public __TLong__ RegisterHouse;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModels\HousesView.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModels\HousesView.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__url__;
    #line default
    #line hidden
    private System.String __bf__House_No__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String House_No {
    #line 4 "ViewModels\HousesView.json"
        get {
        #line hidden
            return Template.House_No.Getter(this); }
        #line 4 "ViewModels\HousesView.json"
        set {
        #line hidden
            Template.House_No.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Street__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Street {
    #line 5 "ViewModels\HousesView.json"
        get {
        #line hidden
            return Template.Street.Getter(this); }
        #line 5 "ViewModels\HousesView.json"
        set {
        #line hidden
            Template.Street.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ZipCode {
    #line 6 "ViewModels\HousesView.json"
        get {
        #line hidden
            return Template.ZipCode.Getter(this); }
        #line 6 "ViewModels\HousesView.json"
        set {
        #line hidden
            Template.ZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__City__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String City {
    #line 7 "ViewModels\HousesView.json"
        get {
        #line hidden
            return Template.City.Getter(this); }
        #line 7 "ViewModels\HousesView.json"
        set {
        #line hidden
            Template.City.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__State__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String State {
    #line 8 "ViewModels\HousesView.json"
        get {
        #line hidden
            return Template.State.Getter(this); }
        #line 8 "ViewModels\HousesView.json"
        set {
        #line hidden
            Template.State.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Country__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Country {
    #line 9 "ViewModels\HousesView.json"
        get {
        #line hidden
            return Template.Country.Getter(this); }
        #line 9 "ViewModels\HousesView.json"
        set {
        #line hidden
            Template.Country.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__TransactionTime__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String TransactionTime {
    #line 10 "ViewModels\HousesView.json"
        get {
        #line hidden
            return Template.TransactionTime.Getter(this); }
        #line 10 "ViewModels\HousesView.json"
        set {
        #line hidden
            Template.TransactionTime.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SalePrice__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SalePrice {
    #line 11 "ViewModels\HousesView.json"
        get {
        #line hidden
            return Template.SalePrice.Getter(this); }
        #line 11 "ViewModels\HousesView.json"
        set {
        #line hidden
            Template.SalePrice.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Commision__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Commision {
    #line 12 "ViewModels\HousesView.json"
        get {
        #line hidden
            return Template.Commision.Getter(this); }
        #line 12 "ViewModels\HousesView.json"
        set {
        #line hidden
            Template.Commision.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__CompleteAddress__;
    #line default
    #line hidden
    private System.String __bf__Longitude__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Longitude {
    #line 14 "ViewModels\HousesView.json"
        get {
        #line hidden
            return Template.Longitude.Getter(this); }
        #line 14 "ViewModels\HousesView.json"
        set {
        #line hidden
            Template.Longitude.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Latitude__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Latitude {
    #line 15 "ViewModels\HousesView.json"
        get {
        #line hidden
            return Template.Latitude.Getter(this); }
        #line 15 "ViewModels\HousesView.json"
        set {
        #line hidden
            Template.Latitude.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__latitude__;
    #line default
    #line hidden
    private System.Int64 __bf__longitude__;
    #line default
    #line hidden
    private System.Int64 __bf__RegisterHouse__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 RegisterHouse {
    #line 18 "ViewModels\HousesView.json"
        get {
        #line hidden
            return Template.RegisterHouse.Getter(this); }
        #line 18 "ViewModels\HousesView.json"
        set {
        #line hidden
            Template.RegisterHouse.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__HousesVi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class url : Input<__HousesVi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class House_No : Input<__HousesVi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Street : Input<__HousesVi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ZipCode : Input<__HousesVi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class City : Input<__HousesVi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class State : Input<__HousesVi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Country : Input<__HousesVi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class TransactionTime : Input<__HousesVi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SalePrice : Input<__HousesVi__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Commision : Input<__HousesVi__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class CompleteAddress : Input<__HousesVi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Longitude : Input<__HousesVi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Latitude : Input<__HousesVi__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class latitude : Input<__HousesVi__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class longitude : Input<__HousesVi__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class RegisterHouse : Input<__HousesVi__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
