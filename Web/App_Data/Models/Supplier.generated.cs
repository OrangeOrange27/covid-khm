//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.6.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Supplier</summary>
	[PublishedModel("supplier")]
	public partial class Supplier : PublishedContentModel, IPerson
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public new const string ModelTypeAlias = "supplier";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Supplier, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Supplier(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Message
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("message")]
		public string Message => global::Umbraco.Web.PublishedModels.Person.GetMessage(this);

		///<summary>
		/// Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("personeName")]
		public string PersoneName => global::Umbraco.Web.PublishedModels.Person.GetPersoneName(this);

		///<summary>
		/// Phone
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.0")]
		[ImplementPropertyType("phone")]
		public string Phone => global::Umbraco.Web.PublishedModels.Person.GetPhone(this);
	}
}
