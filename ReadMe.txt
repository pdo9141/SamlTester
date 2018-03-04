https://www.codeproject.com/Articles/56640/Performing-a-SAML-Post-with-C
Original command from Pre-build event command line in davidsp8.windows.PostSamlAssertion

"$(ProjectDir)..\ThirdPartyAssemlies\ilmerge" /out:$(ProjectDir)..\..\Runtime\davidsp8.common.Security.Saml.All.dll $(ProjectDir)..\davidsp8.common.Security.Saml\bin\Release\davidsp8.common.Security.Saml.dll $(ProjectDir)..\davidsp8.common.Security.Saml11\bin\Release\davidsp8.common.Security.Saml11.dll $(ProjectDir)..\davidsp8.common.Security.Saml20\bin\Release\davidsp8.common.Security.Saml20.dll

01) Change "..\..\Runtime" to "..\Runtime"
02) In davidsp8.windows.PostSamlAssertion Properties > Signing, uncheck sign the ClickOnce Manifest