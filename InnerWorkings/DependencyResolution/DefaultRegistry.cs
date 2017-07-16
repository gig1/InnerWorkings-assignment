// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRegistry.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace InnerWorkings.DependencyResolution {
    using Application.Interfaces;
    using Application.Jobs.Queries.GetJobsList;
    using Persistance;
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;

    public class DefaultRegistry : Registry {
        #region Constructors and Destructors

        public DefaultRegistry() {
            //For<IGetJobsListQuery>().Use<GetJobsListQuery>();
            //For<IDatabaseService>().Use<DatabaseService>();
            //For<System.Data.Entity.DbContext>().Use(() => new ApplicationDbContext());

            Scan(
                scan =>
                {
                    scan.AssembliesFromApplicationBaseDirectory(
                    filter => filter.FullName.StartsWith("Application"));

                    scan.AssembliesFromApplicationBaseDirectory(
                    filter => filter.FullName.StartsWith("Domain"));

                    scan.AssembliesFromApplicationBaseDirectory(
                    filter => filter.FullName.StartsWith("Persistance"));

                    scan.AssembliesFromApplicationBaseDirectory(
                    filter => filter.FullName.StartsWith("InnerWorkings"));

                    scan.WithDefaultConventions();

                    scan.With(new ControllerConvention());

                    //scan.TheCallingAssembly();
                    //scan.WithDefaultConventions();
                    //scan.With(new ControllerConvention());

                    //scan.WithDefaultConventions();
                    //scan.AssemblyContainingType<UserMailer>();
                });
            //For<IExample>().Use<Example>();
        }

        #endregion
    }
}