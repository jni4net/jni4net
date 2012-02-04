#region Copyright (C) 2012 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as
published by the Free Software Foundation, either version 3
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

[assembly: AssemblyDescription("jni4net")]

[assembly: SecurityPermission(SecurityAction.RequestMinimum, Flags = SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.Assertion | SecurityPermissionFlag.Execution)]
[assembly: ReflectionPermission(SecurityAction.RequestMinimum, Unrestricted = true)]
[assembly: FileIOPermission(SecurityAction.RequestMinimum, Unrestricted = true)]
[assembly: EnvironmentPermission(SecurityAction.RequestMinimum, Unrestricted = true)]

[assembly: InternalsVisibleTo("jni4net-w32v20,PublicKey=" +
"00240000048000009400000006020000002400005253413100040000010001001382b0b5167e67" +
"63b767dd8599bf79ff21e6438402e0599d8613684951c55674125ea26ad08b7d2d1c45d9017879" +
"86c656e437d164808ad5355f6efbc708352280cf178715695f12f01d10502cb935cdb18fa5692f" +
"9afb243933ffe96306d09547e16b075c39d49d265ec9df551b9edade19c7d887574baf35784a2e" +
"34efe0bb")]
[assembly: InternalsVisibleTo("jni4net-w32v40,PublicKey=" +
"00240000048000009400000006020000002400005253413100040000010001001382b0b5167e67" +
"63b767dd8599bf79ff21e6438402e0599d8613684951c55674125ea26ad08b7d2d1c45d9017879" +
"86c656e437d164808ad5355f6efbc708352280cf178715695f12f01d10502cb935cdb18fa5692f" +
"9afb243933ffe96306d09547e16b075c39d49d265ec9df551b9edade19c7d887574baf35784a2e" +
"34efe0bb")]
[assembly: InternalsVisibleTo("jni4net-w64v20,PublicKey=" +
"00240000048000009400000006020000002400005253413100040000010001001382b0b5167e67" +
"63b767dd8599bf79ff21e6438402e0599d8613684951c55674125ea26ad08b7d2d1c45d9017879" +
"86c656e437d164808ad5355f6efbc708352280cf178715695f12f01d10502cb935cdb18fa5692f" +
"9afb243933ffe96306d09547e16b075c39d49d265ec9df551b9edade19c7d887574baf35784a2e" +
"34efe0bb")]
[assembly: InternalsVisibleTo("jni4net-w64v40,PublicKey=" +
"00240000048000009400000006020000002400005253413100040000010001001382b0b5167e67" +
"63b767dd8599bf79ff21e6438402e0599d8613684951c55674125ea26ad08b7d2d1c45d9017879" +
"86c656e437d164808ad5355f6efbc708352280cf178715695f12f01d10502cb935cdb18fa5692f" +
"9afb243933ffe96306d09547e16b075c39d49d265ec9df551b9edade19c7d887574baf35784a2e" +
"34efe0bb")]

[assembly: InternalsVisibleTo("jre-micro-j4n,PublicKey=" +
"00240000048000009400000006020000002400005253413100040000010001001382b0b5167e67" +
"63b767dd8599bf79ff21e6438402e0599d8613684951c55674125ea26ad08b7d2d1c45d9017879" +
"86c656e437d164808ad5355f6efbc708352280cf178715695f12f01d10502cb935cdb18fa5692f" +
"9afb243933ffe96306d09547e16b075c39d49d265ec9df551b9edade19c7d887574baf35784a2e" +
"34efe0bb")]
[assembly: InternalsVisibleTo("mscorlib-micro-j4n,PublicKey=" +
"00240000048000009400000006020000002400005253413100040000010001001382b0b5167e67" +
"63b767dd8599bf79ff21e6438402e0599d8613684951c55674125ea26ad08b7d2d1c45d9017879" +
"86c656e437d164808ad5355f6efbc708352280cf178715695f12f01d10502cb935cdb18fa5692f" +
"9afb243933ffe96306d09547e16b075c39d49d265ec9df551b9edade19c7d887574baf35784a2e" +
"34efe0bb")]

[assembly: InternalsVisibleTo("jre-mipro-j4n,PublicKey=" +
"00240000048000009400000006020000002400005253413100040000010001001382b0b5167e67" +
"63b767dd8599bf79ff21e6438402e0599d8613684951c55674125ea26ad08b7d2d1c45d9017879" +
"86c656e437d164808ad5355f6efbc708352280cf178715695f12f01d10502cb935cdb18fa5692f" +
"9afb243933ffe96306d09547e16b075c39d49d265ec9df551b9edade19c7d887574baf35784a2e" +
"34efe0bb")]
[assembly: InternalsVisibleTo("mscorlib-mipro-j4n,PublicKey=" +
"00240000048000009400000006020000002400005253413100040000010001001382b0b5167e67" +
"63b767dd8599bf79ff21e6438402e0599d8613684951c55674125ea26ad08b7d2d1c45d9017879" +
"86c656e437d164808ad5355f6efbc708352280cf178715695f12f01d10502cb935cdb18fa5692f" +
"9afb243933ffe96306d09547e16b075c39d49d265ec9df551b9edade19c7d887574baf35784a2e" +
"34efe0bb")]

[assembly: InternalsVisibleTo("jre15-core-j4n,PublicKey=" +
"00240000048000009400000006020000002400005253413100040000010001001382b0b5167e67"+
"63b767dd8599bf79ff21e6438402e0599d8613684951c55674125ea26ad08b7d2d1c45d9017879"+
"86c656e437d164808ad5355f6efbc708352280cf178715695f12f01d10502cb935cdb18fa5692f"+
"9afb243933ffe96306d09547e16b075c39d49d265ec9df551b9edade19c7d887574baf35784a2e"+
"34efe0bb")]
[assembly: InternalsVisibleTo("jre15-core-j4p,PublicKey=" +
"00240000048000009400000006020000002400005253413100040000010001001382b0b5167e67" +
"63b767dd8599bf79ff21e6438402e0599d8613684951c55674125ea26ad08b7d2d1c45d9017879" +
"86c656e437d164808ad5355f6efbc708352280cf178715695f12f01d10502cb935cdb18fa5692f" +
"9afb243933ffe96306d09547e16b075c39d49d265ec9df551b9edade19c7d887574baf35784a2e" +
"34efe0bb")]


