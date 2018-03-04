Post SAML
https://www.codeproject.com/Articles/56640/Performing-a-SAML-Post-with-C

Validate SAML
https://github.com/jitbit/AspNetSaml

Original command from Pre-build event command line in davidsp8.windows.PostSamlAssertion

"$(ProjectDir)..\ThirdPartyAssemlies\ilmerge" /out:$(ProjectDir)..\..\Runtime\davidsp8.common.Security.Saml.All.dll $(ProjectDir)..\davidsp8.common.Security.Saml\bin\Release\davidsp8.common.Security.Saml.dll $(ProjectDir)..\davidsp8.common.Security.Saml11\bin\Release\davidsp8.common.Security.Saml11.dll $(ProjectDir)..\davidsp8.common.Security.Saml20\bin\Release\davidsp8.common.Security.Saml20.dll

01) Change "..\..\Runtime" to "..\Runtime"
02) In davidsp8.windows.PostSamlAssertion Properties > Signing, uncheck sign the ClickOnce Manifest
03) After first build, copy davidsp8.common.Security.Saml.All.dll in Runtime folder into bin of windows and web.PostSamlAssertion
04) Create two application in IIS, WebServiceProvider and WebIdentityProvider
05) You might have to grant IIS access to your repo folder path (C:\Users\Phillip\Source\Repos), use same as wwwroot
06) Navigate to http://localhost/WebIdentityProvider/Default.aspx