using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox;
namespace DayEight
{
    public class DayEightSolution
    {
        private static string[] input = TBox.GetStringsFromFile(@"C:\Users\josa\Documents\Visual Studio 2017\Projects\AdventOfCode\DayEight\Input.txt");
        private static Dictionary<string,int> registers = new Dictionary<string, int>();
        private static int highestRegisterValue = 0;
        public static int SolutionOne()
        {
            //add all registers to the dictionary
            foreach (var s in input)
            {
                string key = s.Split(' ')[0];
                if (!registers.ContainsKey(key))
                {
                    registers.Add(key, 0);
                }
            }

            //loop through all the input strings and do computations
            foreach (string s in input)
            {
                string[] line = s.Split(' ');
                string fRegister = line[0];
                string sRegister = line[4];
                string instruction = line[1];
                int incrementValue = int.Parse(line[2]);
                int conditionValue = int.Parse(line[6]);
                string condition = line[5];

                switch (condition)
                {
                    case ">":
                        if(registers[sRegister] > conditionValue)
                        {
                            InstructionHandler(fRegister,incrementValue,instruction);
                        }
                        break;
                    case "<":
                        if (registers[sRegister] < conditionValue)
                        {
                            InstructionHandler(fRegister, incrementValue, instruction);
                        }
                        break;
                    case "==":
                        if (registers[sRegister] == conditionValue)
                        {
                            InstructionHandler(fRegister, incrementValue, instruction);
                        }

                        break;
                    case "!=":
                        if (registers[sRegister] != conditionValue)
                        {
                            InstructionHandler(fRegister, incrementValue, instruction);
                        }
                        break;
                    case ">=":
                        if (registers[sRegister] >= conditionValue)
                        {
                            InstructionHandler(fRegister, incrementValue, instruction);
                        }
                        break;
                    case "<=":
                        if (registers[sRegister] <= conditionValue)
                        {
                            InstructionHandler(fRegister, incrementValue, instruction);
                        }
                        break;
                    default:
                        throw new NotImplementedException($"Du mangler operatoren: {condition}");
                        break;
                }
            }

            //find the largest register
            int largestVal = registers.First().Value;
            foreach (var item in registers)
            {
                if(item.Value > largestVal)
                {
                    largestVal = item.Value;
                }
            }

            return highestRegisterValue;
        }
        private static void InstructionHandler(string reg, int value, string instruction)
        {
            if(instruction == "dec")
            {
                Decrement(reg, value);
            } else
            {
                Increment(reg, value);
            }
        }

        private static void Increment(string reg, int value)
        {
            registers[reg] += value;
            CheckForHighestValue(reg);
        }

        private static void Decrement(string reg, int value)
        {
            registers[reg] -= value;
            CheckForHighestValue(reg);
        }

        private static void CheckForHighestValue(string reg)
        {
            if(registers[reg] > highestRegisterValue)
            {
                highestRegisterValue = registers[reg];
            }
        }
    }

}
