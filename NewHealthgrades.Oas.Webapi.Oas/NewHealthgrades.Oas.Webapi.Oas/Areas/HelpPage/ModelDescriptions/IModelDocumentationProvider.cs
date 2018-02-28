using System;
using System.Reflection;

namespace NewHealthgrades.Oas.Webapi.Oas.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}