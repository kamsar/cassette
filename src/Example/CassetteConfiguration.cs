﻿using System.Text.RegularExpressions;
using Cassette;
using Cassette.HtmlTemplates;
using Cassette.ModuleProcessing;
using Cassette.Scripts;
using Cassette.Stylesheets;

namespace Example
{
    public class CassetteConfiguration : ICassetteConfiguration
    {
        public void Configure(ModuleConfiguration modules)
        {
            modules.Add(new PerSubDirectorySource<ScriptModule>("Scripts")
            {
                FilePattern = "*.js",
                Exclude = new Regex("-vsdoc\\.js$")
            });
            modules.Add(new ExternalScriptModule("twitter", "http://platform.twitter.com/widgets.js") { Location = "body" });

            modules.Add(new DirectorySource<StylesheetModule>("Styles")
            {
                FilePattern = "*.css;*.less"
            });

            modules.Add(new PerSubDirectorySource<HtmlTemplateModule>("HtmlTemplates"));

            // TODO: Customize pipelines (e.g. compile LESS)
        }
    }
}