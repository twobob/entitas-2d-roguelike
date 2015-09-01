﻿using System;
using System.Linq;

namespace Entitas.Unity.CodeGenerator {
    public class CodeGeneratorConfig {
        public string generatedFolderPath { 
            get { return _config.GetValueOrDefault(generatedFolderPathKey, defaultgeneratedFolderPath); }
            set { _config[generatedFolderPathKey] = value; }
        }

        public string[] pools {
            get { 
                return _config.GetValueOrDefault(poolsKey, string.Empty)
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(poolName => poolName.Trim())
                    .ToArray();
            }
            set { _config[poolsKey] = string.Join(",", value.Where(pool => !string.IsNullOrEmpty(pool)).ToArray()).Replace(" ", string.Empty); }
        }

        public string[] disabledCodeGenerators {
            get { 
                return _config.GetValueOrDefault(disabledCodeGeneratorsKey, string.Empty)
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(generator => generator.Trim())
                    .ToArray();
            }
            set { _config[disabledCodeGeneratorsKey] = string.Join(",", value.Where(generator => !string.IsNullOrEmpty(generator)).ToArray()).Replace(" ", string.Empty); }
        }

        const string generatedFolderPathKey = "Entitas.Unity.CodeGenerator.GeneratedFolderPath";
        const string poolsKey = "Entitas.Unity.CodeGenerator.Pools";
        const string disabledCodeGeneratorsKey = "Entitas.Unity.CodeGenerator.DisabledCodeGenerators";

        const string defaultgeneratedFolderPath = "Assets/Generated/";

        readonly EntitasPreferencesConfig _config;

        public CodeGeneratorConfig(EntitasPreferencesConfig config) {
            _config = config;
            generatedFolderPath = generatedFolderPath;
            pools = pools;
            disabledCodeGenerators = disabledCodeGenerators;
        }

        public override string ToString() {
            return _config.ToString();
        }
    }
}

