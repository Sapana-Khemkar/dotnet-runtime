// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// ============================================================
//
// TextualIdentityParser.hpp
//


//
// Defines the TextualIdentityParser class
//
// ============================================================

#ifndef __BINDER__TEXTUAL_IDENTITY_PARSER_HPP__
#define __BINDER__TEXTUAL_IDENTITY_PARSER_HPP__

#include "bindertypes.hpp"
#include "stringlexer.hpp"

namespace BINDER_SPACE
{
    class AssemblyVersion;
    class AssemblyIdentity;

    class TextualIdentityParser : public StringLexer
    {
    public:
        TextualIdentityParser(AssemblyIdentity *pAssemblyIdentity);
        ~TextualIdentityParser();

        static HRESULT Parse(/* in */  SString           &textualIdentity,
                             /* out */ AssemblyIdentity *pAssemblyIdentity);

        static HRESULT ToString(/* in */  AssemblyIdentity *pAssemblyIdentity,
                                /* in */  DWORD             dwIdentityFlags,
                                /* out */ SString          &textualIdentity);

        static BOOL ParseVersion(/* in */  SString &versionString,
                                 /* out */ AssemblyVersion *pAssemblyVersion);

        static BOOL HexToBlob(/* in */  SString &publicKeyOrToken,
                              /* in */  BOOL     fValidateHex,
                              /* in */  BOOL     fIsToken,
                              /* out */ SBuffer &publicKeyOrTokenBLOB);

        static void BlobToHex(/* in */  SBuffer &publicKeyOrTokenBLOB,
                              /* out */ SString &publicKeyOrToken);

        BOOL ParseString(/* in */  SString &textualString,
                         /* out */ SString &contentString);

    protected:
        BOOL Parse(/* in */  SString &textualIdentity);

        BOOL PopulateAssemblyIdentity(/* in */ SString &attributeString,
                                      /* in */ SString &valueString);

        static void EscapeString(/* in */ SString &input,
                                 /* out*/ SString &result);

        AssemblyIdentity *m_pAssemblyIdentity;
        DWORD m_dwAttributesSeen;
    };
};

#endif
