






















#pragma warning disable 1591
#pragma warning disable 0108
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Team Development for Sitecore.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;   
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;
using Sitecore.Data;
using Sitecore.Globalization;
using Sitecore.Data.Items;



namespace DoctaCore.Project.Demo
{

	public interface IGlassBase{
		
		[SitecoreId]
		Guid Id{ get; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; }

		[SitecoreInfo(SitecoreInfoType.Name)]
		string Name {get; }

	}

	public abstract class GlassBase : IGlassBase{
		
		[SitecoreId]
		public virtual Guid Id{ get; private set;}

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; private set; }

		[SitecoreInfo(SitecoreInfoType.Name)]
		public virtual string Name {get; set;}

		[SitecoreItem]
        public virtual Item Item { get; private set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; private set; }
	}
}
/******

//Razor View Model - For Copy Pasting
@using Sitecore.XA.Foundation.MarkupDecorator.Extensions
@using Sitecore.XA.Foundation.SitecoreExtensions.Extensions
@using DoctaCore.Project.Demo

@inherits Glass.Mapper.Sc.Web.Mvc.GlassView<SF.Foundation.GlassBootstrap.Models.RenderingGlassModel<DoctaCore.Project.Demo.Article>>

<div @Html.Sxa().Component(this.CssClasses("article"), Model.Attributes)>
    <div class="component-content">

    

    </div>
</div>

****/

/******

//Handlebar Templates - For Copy Pasting
<div class="article">

    <div class="featured-contents">
        {{{FeaturedContents}}}
    </div>

    <div class="introduction">
        {{{Introduction}}}
    </div>

    <div class="main-content">
        {{{MainContent}}}
    </div>

    <div class="title">
        {{{Title}}}
    </div>

</div>    
****/

namespace DoctaCore.Project.Demo
{
 	/// <summary>
	/// IArticle Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Project/Demo/Page Types/Article</para>	
	/// <para>ID: 0e7add70-1756-45b7-b0a3-95af072fc68f</para>	
	/// </summary>
	public interface IArticle : IGlassBase , global::DoctaCore.Project.Demo.IBase_Page
	{

	}

	
	/// <summary>
	/// Article
	/// <para></para>
	/// <para>Path: /sitecore/templates/Project/Demo/Page Types/Article</para>	
	/// <para>ID: 0e7add70-1756-45b7-b0a3-95af072fc68f</para>	
	/// </summary>
	[SitecoreType(TemplateId="0e7add70-1756-45b7-b0a3-95af072fc68f")]
	public partial class Article  : GlassBase, IArticle 
	{
        public static readonly ID TemplateId = new ID("0e7add70-1756-45b7-b0a3-95af072fc68f");
		public static readonly string TemplateName="Article";


		/// <summary>
		/// The Featured Content field.
		/// <para></para>
		/// <para>Field Type: Multilist</para>		
		/// <para>Field ID: eafe0951-3b1f-4689-81b3-c47a4fedbf23</para>
		/// <para>Custom Data: type=IEnumerable<DoctaCore.Project.Demo.Base_Page></para>
		/// </summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
		[SitecoreField("Featured Content")]
		public virtual IEnumerable<DoctaCore.Project.Demo.Base_Page> Featured_Contents  {get; set;}
			

		/// <summary>
		/// The Introduction field.
		/// <para></para>
		/// <para>Field Type: Rich Text</para>		
		/// <para>Field ID: 66f51940-5f6f-404b-8dd9-81dee8e6bb07</para>
		/// <para>Custom Data: </para>
		/// </summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
		[SitecoreField("Introduction")]
		public virtual string Introduction  {get; set;}
			

		/// <summary>
		/// The Main Content field.
		/// <para></para>
		/// <para>Field Type: Rich Text</para>		
		/// <para>Field ID: 07b7ab11-8edf-4edb-a1cc-7c981b2dee04</para>
		/// <para>Custom Data: </para>
		/// </summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
		[SitecoreField("Main Content")]
		public virtual string Main_Content  {get; set;}
			

		/// <summary>
		/// The Title field.
		/// <para></para>
		/// <para>Field Type: Single-Line Text</para>		
		/// <para>Field ID: 714309bb-79c4-4491-a709-cd790d4b59fb</para>
		/// <para>Custom Data: </para>
		/// </summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
		[SitecoreField("Title")]
		public virtual string Title  {get; set;}
			
	

public static class Fields
{
	
}

	}

}
/******

//Razor View Model - For Copy Pasting
@using Sitecore.XA.Foundation.MarkupDecorator.Extensions
@using Sitecore.XA.Foundation.SitecoreExtensions.Extensions
@using DoctaCore.Project.Demo

@inherits Glass.Mapper.Sc.Web.Mvc.GlassView<SF.Foundation.GlassBootstrap.Models.RenderingGlassModel<DoctaCore.Project.Demo.Home>>

<div @Html.Sxa().Component(this.CssClasses("home"), Model.Attributes)>
    <div class="component-content">

    

    </div>
</div>

****/

/******

//Handlebar Templates - For Copy Pasting
<div class="home">

    <div class="featured-contents">
        {{{FeaturedContents}}}
    </div>

    <div class="introduction">
        {{{Introduction}}}
    </div>

    <div class="main-content">
        {{{MainContent}}}
    </div>

    <div class="title">
        {{{Title}}}
    </div>

</div>    
****/

namespace DoctaCore.Project.Demo
{
 	/// <summary>
	/// IHome Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Project/Demo/Page Types/Home</para>	
	/// <para>ID: 61e89ebd-e65a-4d16-9880-88a88334f882</para>	
	/// </summary>
	public interface IHome : IGlassBase , global::DoctaCore.Project.Demo.IBase_Page
	{

	}

	
	/// <summary>
	/// Home
	/// <para></para>
	/// <para>Path: /sitecore/templates/Project/Demo/Page Types/Home</para>	
	/// <para>ID: 61e89ebd-e65a-4d16-9880-88a88334f882</para>	
	/// </summary>
	[SitecoreType(TemplateId="61e89ebd-e65a-4d16-9880-88a88334f882")]
	public partial class Home  : GlassBase, IHome 
	{
        public static readonly ID TemplateId = new ID("61e89ebd-e65a-4d16-9880-88a88334f882");
		public static readonly string TemplateName="Home";


		/// <summary>
		/// The Featured Content field.
		/// <para></para>
		/// <para>Field Type: Multilist</para>		
		/// <para>Field ID: eafe0951-3b1f-4689-81b3-c47a4fedbf23</para>
		/// <para>Custom Data: type=IEnumerable<DoctaCore.Project.Demo.Base_Page></para>
		/// </summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
		[SitecoreField("Featured Content")]
		public virtual IEnumerable<DoctaCore.Project.Demo.Base_Page> Featured_Contents  {get; set;}
			

		/// <summary>
		/// The Introduction field.
		/// <para></para>
		/// <para>Field Type: Rich Text</para>		
		/// <para>Field ID: 66f51940-5f6f-404b-8dd9-81dee8e6bb07</para>
		/// <para>Custom Data: </para>
		/// </summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
		[SitecoreField("Introduction")]
		public virtual string Introduction  {get; set;}
			

		/// <summary>
		/// The Main Content field.
		/// <para></para>
		/// <para>Field Type: Rich Text</para>		
		/// <para>Field ID: 07b7ab11-8edf-4edb-a1cc-7c981b2dee04</para>
		/// <para>Custom Data: </para>
		/// </summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
		[SitecoreField("Main Content")]
		public virtual string Main_Content  {get; set;}
			

		/// <summary>
		/// The Title field.
		/// <para></para>
		/// <para>Field Type: Single-Line Text</para>		
		/// <para>Field ID: 714309bb-79c4-4491-a709-cd790d4b59fb</para>
		/// <para>Custom Data: </para>
		/// </summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
		[SitecoreField("Title")]
		public virtual string Title  {get; set;}
			
	

public static class Fields
{
	
}

	}

}
/******

//Razor View Model - For Copy Pasting
@using Sitecore.XA.Foundation.MarkupDecorator.Extensions
@using Sitecore.XA.Foundation.SitecoreExtensions.Extensions
@using DoctaCore.Project.Demo

@inherits Glass.Mapper.Sc.Web.Mvc.GlassView<SF.Foundation.GlassBootstrap.Models.RenderingGlassModel<DoctaCore.Project.Demo.Base_Page>>

<div @Html.Sxa().Component(this.CssClasses("base-page"), Model.Attributes)>
    <div class="component-content">

    
        <div class="featured-contents">
            @Editable(Model.GlassModel, x => x.Featured_Contents)
        </div>
    
        <div class="introduction">
            @Editable(Model.GlassModel, x => x.Introduction)
        </div>
    
        <div class="main-content">
            @Editable(Model.GlassModel, x => x.Main_Content)
        </div>
    
        <div class="title">
            @Editable(Model.GlassModel, x => x.Title)
        </div>
    

    </div>
</div>

****/

/******

//Handlebar Templates - For Copy Pasting
<div class="base-page">

    <div class="featured-contents">
        {{{FeaturedContents}}}
    </div>

    <div class="introduction">
        {{{Introduction}}}
    </div>

    <div class="main-content">
        {{{MainContent}}}
    </div>

    <div class="title">
        {{{Title}}}
    </div>

</div>    
****/

namespace DoctaCore.Project.Demo
{
 	/// <summary>
	/// IBase_Page Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Project/Demo/Page Types/Base Page</para>	
	/// <para>ID: c14f0635-6f2f-4271-be31-f79276042588</para>	
	/// </summary>
	public interface IBase_Page : IGlassBase 
	{

		/// <summary>
		/// The Featured Content field.
		/// <para></para>
		/// <para>Field Type: Multilist</para>		
		/// <para>Field ID: eafe0951-3b1f-4689-81b3-c47a4fedbf23</para>
		/// <para>Custom Data: type=IEnumerable<DoctaCore.Project.Demo.Base_Page></para>
		/// </summary>
		IEnumerable<DoctaCore.Project.Demo.Base_Page> Featured_Contents  {get; set;}
			

		/// <summary>
		/// The Introduction field.
		/// <para></para>
		/// <para>Field Type: Rich Text</para>		
		/// <para>Field ID: 66f51940-5f6f-404b-8dd9-81dee8e6bb07</para>
		/// <para>Custom Data: </para>
		/// </summary>
		string Introduction  {get; set;}
			

		/// <summary>
		/// The Main Content field.
		/// <para></para>
		/// <para>Field Type: Rich Text</para>		
		/// <para>Field ID: 07b7ab11-8edf-4edb-a1cc-7c981b2dee04</para>
		/// <para>Custom Data: </para>
		/// </summary>
		string Main_Content  {get; set;}
			

		/// <summary>
		/// The Title field.
		/// <para></para>
		/// <para>Field Type: Single-Line Text</para>		
		/// <para>Field ID: 714309bb-79c4-4491-a709-cd790d4b59fb</para>
		/// <para>Custom Data: </para>
		/// </summary>
		string Title  {get; set;}
			

	}

	
	/// <summary>
	/// Base_Page
	/// <para></para>
	/// <para>Path: /sitecore/templates/Project/Demo/Page Types/Base Page</para>	
	/// <para>ID: c14f0635-6f2f-4271-be31-f79276042588</para>	
	/// </summary>
	[SitecoreType(TemplateId="c14f0635-6f2f-4271-be31-f79276042588")]
	public partial class Base_Page  : GlassBase, IBase_Page 
	{
        public static readonly ID TemplateId = new ID("c14f0635-6f2f-4271-be31-f79276042588");
		public static readonly string TemplateName="Base Page";


		/// <summary>
		/// The Featured Content field.
		/// <para></para>
		/// <para>Field Type: Multilist</para>		
		/// <para>Field ID: eafe0951-3b1f-4689-81b3-c47a4fedbf23</para>
		/// <para>Custom Data: type=IEnumerable<DoctaCore.Project.Demo.Base_Page></para>
		/// </summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
		[SitecoreField("Featured Content")]
		public virtual IEnumerable<DoctaCore.Project.Demo.Base_Page> Featured_Contents  {get; set;}
			

		/// <summary>
		/// The Introduction field.
		/// <para></para>
		/// <para>Field Type: Rich Text</para>		
		/// <para>Field ID: 66f51940-5f6f-404b-8dd9-81dee8e6bb07</para>
		/// <para>Custom Data: </para>
		/// </summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
		[SitecoreField("Introduction")]
		public virtual string Introduction  {get; set;}
			

		/// <summary>
		/// The Main Content field.
		/// <para></para>
		/// <para>Field Type: Rich Text</para>		
		/// <para>Field ID: 07b7ab11-8edf-4edb-a1cc-7c981b2dee04</para>
		/// <para>Custom Data: </para>
		/// </summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
		[SitecoreField("Main Content")]
		public virtual string Main_Content  {get; set;}
			

		/// <summary>
		/// The Title field.
		/// <para></para>
		/// <para>Field Type: Single-Line Text</para>		
		/// <para>Field ID: 714309bb-79c4-4491-a709-cd790d4b59fb</para>
		/// <para>Custom Data: </para>
		/// </summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
		[SitecoreField("Title")]
		public virtual string Title  {get; set;}
			
	

public static class Fields
{

		public static Guid Featured_Contents  
        {
            get 
            {
                return new Guid("eafe0951-3b1f-4689-81b3-c47a4fedbf23");
            }
        }
			

		public static Guid Introduction  
        {
            get 
            {
                return new Guid("66f51940-5f6f-404b-8dd9-81dee8e6bb07");
            }
        }
			

		public static Guid Main_Content  
        {
            get 
            {
                return new Guid("07b7ab11-8edf-4edb-a1cc-7c981b2dee04");
            }
        }
			

		public static Guid Title  
        {
            get 
            {
                return new Guid("714309bb-79c4-4491-a709-cd790d4b59fb");
            }
        }
			
	
}

	}

}
/******

//Razor View Model - For Copy Pasting
@using Sitecore.XA.Foundation.MarkupDecorator.Extensions
@using Sitecore.XA.Foundation.SitecoreExtensions.Extensions
@using DoctaCore.Project.Demo

@inherits Glass.Mapper.Sc.Web.Mvc.GlassView<SF.Foundation.GlassBootstrap.Models.RenderingGlassModel<DoctaCore.Project.Demo.Site_Root>>

<div @Html.Sxa().Component(this.CssClasses("site-root"), Model.Attributes)>
    <div class="component-content">

    

    </div>
</div>

****/

/******

//Handlebar Templates - For Copy Pasting
<div class="site-root">

</div>    
****/

namespace DoctaCore.Project.Demo
{
 	/// <summary>
	/// ISite_Root Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/Project/Demo/Content Types/Site Root</para>	
	/// <para>ID: faf4d312-b07c-404e-89ee-ca43b8c9a015</para>	
	/// </summary>
	public interface ISite_Root : IGlassBase 
	{

	}

	
	/// <summary>
	/// Site_Root
	/// <para></para>
	/// <para>Path: /sitecore/templates/Project/Demo/Content Types/Site Root</para>	
	/// <para>ID: faf4d312-b07c-404e-89ee-ca43b8c9a015</para>	
	/// </summary>
	[SitecoreType(TemplateId="faf4d312-b07c-404e-89ee-ca43b8c9a015")]
	public partial class Site_Root  : GlassBase, ISite_Root 
	{
        public static readonly ID TemplateId = new ID("faf4d312-b07c-404e-89ee-ca43b8c9a015");
		public static readonly string TemplateName="Site Root";

	

public static class Fields
{
	
}

	}

}
