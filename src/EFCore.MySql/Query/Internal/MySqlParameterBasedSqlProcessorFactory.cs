// Copyright (c) Pomelo Foundation. All rights reserved.
// Licensed under the MIT. See LICENSE in the project root for license information.

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Query;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure.Internal;

namespace Pomelo.EntityFrameworkCore.MySql.Query.Internal
{
    public class MySqlParameterBasedSqlProcessorFactory : IRelationalParameterBasedSqlProcessorFactory
    {
        private readonly RelationalParameterBasedSqlProcessorDependencies _dependencies;
        private readonly RelationalParameterBasedSqlProcessorParameters _parameters;
        [NotNull] private readonly IMySqlOptions _options;

        public MySqlParameterBasedSqlProcessorFactory(
            [NotNull] RelationalParameterBasedSqlProcessorDependencies dependencies,
            [NotNull] RelationalParameterBasedSqlProcessorParameters parameters,
            [NotNull] IMySqlOptions options)
        {
            _dependencies = dependencies;
            _parameters = parameters;
            _options = options;
        }

        public virtual RelationalParameterBasedSqlProcessor Create(bool useRelationalNulls)
            => new MySqlParameterBasedSqlProcessor(_dependencies, _parameters, _options);

        public RelationalParameterBasedSqlProcessor Create(RelationalParameterBasedSqlProcessorParameters parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}
