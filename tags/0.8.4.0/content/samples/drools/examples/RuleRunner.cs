/**
 * Copyright 2010 JBoss Inc
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.ObjectModel;
using System.IO;
using org.drools.builder;
using org.drools.definition;
using org.drools.io;
using org.drools.runtime;

namespace org.drools.tutorials.banking
{
    public class RuleRunner
    {
        public void runRules(String[] rules, java.lang.Object[] facts)
        {
            KnowledgeBase kbase = KnowledgeBaseFactory.newKnowledgeBase();
            KnowledgeBuilder kbuilder = KnowledgeBuilderFactory.newKnowledgeBuilder();

            for (int i = 0; i < rules.Length; i++)
            {
                String ruleFile = rules[i];
                Console.WriteLine("Loading file: " + ruleFile);
                ruleFile = Path.GetFullPath(Path.Combine("rules", ruleFile));
                kbuilder.add(ResourceFactory.newFileResource(ruleFile), ResourceType.DRL );
            }

            java.util.Collection pkgs = kbuilder.getKnowledgePackages();
            kbase.addKnowledgePackages(pkgs);
            StatefulKnowledgeSession ksession = kbase.newStatefulKnowledgeSession();

            for (int i = 0; i < facts.Length; i++)
            {
                java.lang.Object fact = facts[i];
                //Console.WriteLine("Inserting fact: " + fact);
                ksession.insert(fact);
            }

            

            ksession.fireAllRules();
        }
    }
} 