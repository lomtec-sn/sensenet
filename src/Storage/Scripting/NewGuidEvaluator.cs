using System;
using System.Collections.Generic;
using System.Text;
using SenseNet.ContentRepository.Storage.Scripting;

namespace SenseNet.Storage.Scripting
{
    [ScriptTagNameAttribute("csnewguid")]
    public class NewGuidEvaluator : IEvaluator
    {
        public string Evaluate(string source)
        {
            var millisecond = DateTime.Now.Millisecond % 10;
            Guid newGuid;
            for (int i = -2; i < millisecond; i++)
            {
                newGuid = Guid.NewGuid();
            }
            return newGuid.ToString();
        }
    }
}