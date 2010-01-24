Getting Started

* {Building NMaven}

** Prerequisites

 Prior to building NMaven, make sure that you have the following installed on your system:

  [[1]] {{{ http://java.sun.com/javase/downloads/index_jdk5.jsp} JDK 5.0 Update x}}

  [[2]] For Microsoft builds you will need both {{{http://msdn2.microsoft.com/en-us/downloads/default.aspx} Microsoft .NET Framework}} (1.1+)
     AND {{{http://msdn2.microsoft.com/en-us/downloads/default.aspx} NET Framework SDK}}. For Mono builds, you will need
     {{{http://www.mono-project.com} Mono}} (tested with 1.2.3.1+).

  [[3]] Subversion client 1.3+. Click here for
 {{{ http://subversion.tigris.org/servlets/ProjectDocumentView?documentID=35379&showInfo=true} Windows Subversion Client}}.

  [[4]] {{{http://maven.apache.org/download.html} Maven 2.0.7+}}

[]

  Optional programs:

  [[1]] {{{http://nunit.org/index.php?p=download} NUnit 2.4.x+}} (Currently only supported building with Microsoft)

** Paths

 You will need to make sure that you have both the SDK and the .NET framework locations within your path.
 On Linux distributions, this should already be in your path. Typical locations for Microsoft include:

 * install root: C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727

 * SDK root: C:\Program Files\Microsoft.NET\SDK\v2.0\

  []

 On Windows, Mono looks something like:

 * install root/SDK path: C:\Program Files\Mono-1.2.3.1\bin

 []

 If you are using NUnit, add the NUnit bin to your path.

** Build

    To build NMaven:

    [[1]] Do an SVN checkout

+----+
  svn co https://svn.apache.org/repos/asf/incubator/nmaven/trunk nmaven
+----+

    [[2]] Run

+----+
  mvn install
+----+

 To run with integration tests:

+----+
  mvn install -P run-its
+----+

** Linux Specific Setup

 Building on Linux, may take some extra steps. By default, on many Linux environments, the GNU Compiler for Java is already
 installed. The current GNU version may not work with NMaven, which requires JDK 1.5. To check which version the system uses, type "java -version"
 on the command line. If you see something similar to the following, you will need to take additional steps to get the
 build setup:

+----+

java version "1.4.2"
gij (GNU libgcj) version 4.1.1 20060525 (Red Hat 4.1.1-1)
+----+

 Create a file "/etc/profile.d/java.sh" with the following entries:

+----+

 export JAVA_HOME=/usr/java/jdk1.5.0_09
 export PATH=$JAVA_HOME/bin:$PATH
+----+

 Type "mvn -version" from the command line. You should see the following:

+----+

java version "1.5.0_09"
Java(TM) 2 Runtime Environment, Standard Edition (build 1.5.0_09-b01)
Java HotSpot(TM) Client VM (build 1.5.0_09-b01, mixed mode, sharing)
+----+

 You can try to build with the default version of Mono installed. If it doesn't work,
 type "mono -V" on the command line to see what version you are running. If it is below 1.2.3.1, then download the
 latest mono version, unzip and run rpm from the commandline. Detailed instructions are located here:
 {{{ http://www.mono-project.com/Getting_Mono}Installing Mono}}. Make sure to su to root before installing with these
 instructions!

* {Signing Assemblies}

 To create a key

+----+
 sn -k sgKey.snk
+----+

 NMaven supports compile-time signing of assemblies. You can sign assemblies by using the keyfile field in the
 maven-dotnet-compiler-plugin.

+----+
  <build>
    <sourceDirectory>.</sourceDirectory>
    <plugins>
      <plugin>
        <groupId>org.sonatype.nmaven.plugins</groupId>
        <artifactId>maven-dotnet-compiler-plugin</artifactId>
        <extensions>true</extensions>
        <configuration>
          <keyfile>sgKey.snk/keyfile>
        </configuration>
      </plugin>
    </plugins>
  </build>
+----+

 Key signing is currently only supported for .NET framework 2.0.

* {Assembly Info}

 Provided that you do not have your own AssemblyInfo class in your project, NMaven will automatically generate
 an AssemblyInfo.* for you. It does the following mapping:

*-------------------------+--------------------------------------------+
| AssemblyDescription | $\{project.description\} |
*-------------------------+--------------------------------------------+
| AssemblyVersion | $\{project.version\} |
*-------------------------+--------------------------------------------+
| AssemblyTitle | $\{project.name\} |
*-------------------------+--------------------------------------------+
| AssemblyCompany | $\{project.organization.name\} |
*-------------------------+--------------------------------------------+
| AssemblyProduct | $\{project.organization.name\}-$\{project.name\} |
*-------------------------+--------------------------------------------+
| AssemblyCopyright | place a COPYRIGHT.txt file in your module directory and NMaven will pick it up and put it in the assembly |
*-------------------------+--------------------------------------------+

 Since the pom version is mapped to the assembly manifest, you MUST follow the 0.0.0.0 version convention or the build
 will fail. You may, however, optionally add additional tags after the 0.0.0.0 version, such as -SNAPSHOT, alpha, etc.
 Valid versions would include 1.3.4 or 1.2-SNAPSHOT or 1.2-RC1.

* {Compiling Projects}

 NMaven supports compiling of exe, winexe, library, and netmodule projects.

*-------------------------+--------------------------------------------+
| <<Target Type>> | <<Packaging>> |
*-------------------------+--------------------------------------------+
| exe | dotnet:exe |
*-------------------------+--------------------------------------------+
| winexe | dotnet:winexe |
*-------------------------+--------------------------------------------+
| library | dotnet:library |
*-------------------------+--------------------------------------------+
| netmodule | dotnet:module |
*-------------------------+--------------------------------------------+

 For example, the pom for compiling a library would look like:

+----+
<?xml version="1.0" encoding="UTF-8"?>

<project>
  <modelVersion>4.0.0</modelVersion>
  <groupId>NMaven.Its</groupId>
  <artifactId>NMaven.It.It0000</artifactId>
  <packaging>dotnet:library</packaging>
  <version>1.0.0</version>
  <name>NMaven.It.It0000</name>
  <build>
    <sourceDirectory>.</sourceDirectory>
    <testSourceDirectory>Test</testSourceDirectory>
    <plugins>
      <plugin>
        <groupId>org.sonatype.nmaven.plugins</groupId>
        <artifactId>maven-dotnet-compiler-plugin</artifactId>
        <extensions>true</extensions>
      </plugin>
    </plugins>
  </build>
</project>
+----+

 If you are using Mono on Windows, then set the vendor tag. If you are compiling on a non-Windows platform, then you do not need to set the
 tag.

+----+
<plugins>
  <plugin>
    <groupId>org.sonatype.nmaven.plugins</groupId>
    <artifactId>maven-dotnet-compiler-plugin</artifactId>
    <extensions>true</extensions>
    <configuration>
      <vendor>NOVELL</vendor>
    </configuration>
  </plugin>
</plugins>
+----+

* {Project Dependencies}

 To use a gac dependency, you will need to set a GAC_ROOT environment variable to point to either the Microsoft or Mono
  GAC root location. Then use the system scope as shown below. You can also use types: dotnet:gac_32 and dotnet:gac.

+----+
<dependency>
  <groupId>System.Windows.Forms</groupId>
  <artifactId>System.Windows.Forms</artifactId>
  <version>2.0.0.0</version>
  <type>dotnet:gac_msil</type>
  <scope>system</scope>
  <classifier>b77a5c561934e089</classifier>
  <systemPath>
    ${env.GAC_ROOT}\GAC_MSIL\System.Windows.Forms\2.0.0.0__b77a5c561934e089\System.Windows.Forms.dll
    </systemPath>
</dependency>
+----+

 A typical dependency would look like.

+----+
  <dependencies>
    <dependency>
      <groupId>NMaven.Its</groupId>
      <artifactId>NMaven.It.It0004</artifactId>
      <version>1.0.0</version>
      <type>dotnet:library</type>
    </dependency>
  </dependencies>
+----+

 dotnet:winexe and dotnet:exe can also be used as dependency types. dotnet:module can also be used but will not be transitive.

