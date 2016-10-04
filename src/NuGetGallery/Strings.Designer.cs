﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetGallery {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGetGallery.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are already logged in!.
        /// </summary>
        public static string AlreadyLoggedIn {
            get {
                return ResourceManager.GetString("AlreadyLoggedIn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Note that your API key has also been updated..
        /// </summary>
        public static string ApiKeyAlsoUpdated {
            get {
                return ResourceManager.GetString("ApiKeyAlsoUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to API key can not be the default Guid..
        /// </summary>
        public static string ApiKeyCanNotBeDefaultGuid {
            get {
                return ResourceManager.GetString("ApiKeyCanNotBeDefaultGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A new API key has been generated. Check below and make sure to copy the value, as now is the only time it will be visible..
        /// </summary>
        public static string ApiKeyGenerated {
            get {
                return ResourceManager.GetString("ApiKeyGenerated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified API key is invalid, has expired, or does not have permission to access the specified package..
        /// </summary>
        public static string ApiKeyNotAuthorized {
            get {
                return ResourceManager.GetString("ApiKeyNotAuthorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An API key must be provided in the &apos;X-NuGet-ApiKey&apos; header to use this service.
        /// </summary>
        public static string ApiKeyRequired {
            get {
                return ResourceManager.GetString("ApiKeyRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must confirm the email address for the account in order to use the API key..
        /// </summary>
        public static string ApiKeyUserAccountIsUnconfirmed {
            get {
                return ResourceManager.GetString("ApiKeyUserAccountIsUnconfirmed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; authentication provider is disabled and cannot be used to authenticate
        ///.
        /// </summary>
        public static string AuthenticationProviderDisabled {
            get {
                return ResourceManager.GetString("AuthenticationProviderDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Azure Active Directory Account.
        /// </summary>
        public static string AzureActiveDirectory_AccountNoun {
            get {
                return ResourceManager.GetString("AzureActiveDirectory_AccountNoun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Azure Active Directory.
        /// </summary>
        public static string AzureActiveDirectory_Caption {
            get {
                return ResourceManager.GetString("AzureActiveDirectory_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sign in with Azure Active Directory.
        /// </summary>
        public static string AzureActiveDirectory_SignInMessage {
            get {
                return ResourceManager.GetString("AzureActiveDirectory_SignInMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You canceled your email address change request..
        /// </summary>
        public static string CancelEmailAddress {
            get {
                return ResourceManager.GetString("CancelEmailAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Oops! You can&apos;t remove the only credential that can be used to log in to the website!.
        /// </summary>
        public static string CannotRemoveOnlyLoginCredential {
            get {
                return ResourceManager.GetString("CannotRemoveOnlyLoginCredential", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SKIPPED! Package file blob {0} already exists.
        /// </summary>
        public static string CopyExternalPackages_PackageFileBlobAlreadyExists {
            get {
                return ResourceManager.GetString("CopyExternalPackages_PackageFileBlobAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saving the package file {0} to blob storage as {1}.
        /// </summary>
        public static string CopyExternalPackages_SavingPackageFileBlob {
            get {
                return ResourceManager.GetString("CopyExternalPackages_SavingPackageFileBlob", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find anyone with that email..
        /// </summary>
        public static string CouldNotFindAnyoneWithThatEmail {
            get {
                return ResourceManager.GetString("CouldNotFindAnyoneWithThatEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The credential has been expired..
        /// </summary>
        public static string CredentialExpired {
            get {
                return ResourceManager.GetString("CredentialExpired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The credential has been removed.
        /// </summary>
        public static string CredentialRemoved {
            get {
                return ResourceManager.GetString("CredentialRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to API Key.
        /// </summary>
        public static string CredentialType_ApiKey {
            get {
                return ResourceManager.GetString("CredentialType_ApiKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password.
        /// </summary>
        public static string CredentialType_Password {
            get {
                return ResourceManager.GetString("CredentialType_Password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current password you provided is incorrect..
        /// </summary>
        public static string CurrentPasswordIncorrect {
            get {
                return ResourceManager.GetString("CurrentPasswordIncorrect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The NuGet service is experiencing a service interruption. Try requesting a specific package version instead..
        /// </summary>
        public static string DatabaseUnavailable_TrySpecificVersion {
            get {
                return ResourceManager.GetString("DatabaseUnavailable_TrySpecificVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unexpected error occurred. Contact support for assistance..
        /// </summary>
        public static string DefaultUserSafeExceptionMessage {
            get {
                return ResourceManager.GetString("DefaultUserSafeExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email address &apos;{0}&apos; is being used..
        /// </summary>
        public static string EmailAddressBeingUsed {
            get {
                return ResourceManager.GetString("EmailAddressBeingUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your email preferences have been updated.
        /// </summary>
        public static string EmailPreferencesUpdated {
            get {
                return ResourceManager.GetString("EmailPreferencesUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A {0} was added to your account and can now be used to log in. If you did not request this change, please reply to this email to contact support..
        /// </summary>
        public static string Emails_CredentialAdded_Body {
            get {
                return ResourceManager.GetString("Emails_CredentialAdded_Body", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{0}] {1} added to your account.
        /// </summary>
        public static string Emails_CredentialAdded_Subject {
            get {
                return ResourceManager.GetString("Emails_CredentialAdded_Subject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A {0} was removed from your account and can no longer be used to log in. If you did not request this change, please reply to this email to contact support..
        /// </summary>
        public static string Emails_CredentialRemoved_Body {
            get {
                return ResourceManager.GetString("Emails_CredentialRemoved_Body", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{0}] {1} removed from your account.
        /// </summary>
        public static string Emails_CredentialRemoved_Subject {
            get {
                return ResourceManager.GetString("Emails_CredentialRemoved_Subject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The word on the street is you lost your password. Sorry to hear it!
        ///If you haven&apos;t forgotten your password you can safely ignore this email. Your password has not been changed.
        ///
        ///Click the following link within the next hour to reset your password:
        ///
        ///[{0}]({0})
        ///
        ///Thanks,
        ///The {1} Team.
        /// </summary>
        public static string Emails_ForgotPassword_Body {
            get {
                return ResourceManager.GetString("Emails_ForgotPassword_Body", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{0}] Please reset your password..
        /// </summary>
        public static string Emails_ForgotPassword_Subject {
            get {
                return ResourceManager.GetString("Emails_ForgotPassword_Subject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The word on the street is you want to set a password for your account.
        ///If you didn&apos;t request a password, you can safely ignore this message. A password has not yet been set.
        ///
        ///Click the following link within the next hour to set your password:
        ///
        ///[{0}]({0})
        ///
        ///Thanks,
        ///The {1} Team.
        /// </summary>
        public static string Emails_SetPassword_Body {
            get {
                return ResourceManager.GetString("Emails_SetPassword_Body", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{0}] Please set your password..
        /// </summary>
        public static string Emails_SetPassword_Subject {
            get {
                return ResourceManager.GetString("Emails_SetPassword_Subject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your new email address was saved!.
        /// </summary>
        public static string EmailUpdated {
            get {
                return ResourceManager.GetString("EmailUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your email address has been changed! We sent a confirmation email to verify your new email. When you confirm the new email address, it will take effect and we will forget the old one..
        /// </summary>
        public static string EmailUpdated_ConfirmationRequired {
            get {
                return ResourceManager.GetString("EmailUpdated_ConfirmationRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error in sending mail : {0}.
        /// </summary>
        public static string ErrorInSendingMail {
            get {
                return ResourceManager.GetString("ErrorInSendingMail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your external account credential expired or you did not allow us access to your account. Try logging in again..
        /// </summary>
        public static string ExternalAccountLinkExpired {
            get {
                return ResourceManager.GetString("ExternalAccountLinkExpired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read the package file. Ensure it is a valid NuGet package with a valid manifest..
        /// </summary>
        public static string FailedToReadUploadFile {
            get {
                return ResourceManager.GetString("FailedToReadUploadFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (404) Error - Not Found.
        /// </summary>
        public static string Http404NotFound {
            get {
                return ResourceManager.GetString("Http404NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Index does not exist.
        /// </summary>
        public static string IndexDoesNotExist {
            get {
                return ResourceManager.GetString("IndexDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The API key &apos;{0}&apos; is invalid..
        /// </summary>
        public static string InvalidApiKey {
            get {
                return ResourceManager.GetString("InvalidApiKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Password Reset Token is not valid or expired..
        /// </summary>
        public static string InvalidOrExpiredPasswordResetToken {
            get {
                return ResourceManager.GetString("InvalidOrExpiredPasswordResetToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package framework &apos;{0}&apos; is not supported. Frameworks within the portable profile are not allowed to have profiles themselves..
        /// </summary>
        public static string InvalidPortableFramework {
            get {
                return ResourceManager.GetString("InvalidPortableFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job Log Blob name is invalid Bob! Expected [jobname].[yyyy-MM-dd].json or [jobname].json. Got: {0}.
        /// </summary>
        public static string JobLogBlobNameInvalid {
            get {
                return ResourceManager.GetString("JobLogBlobNameInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot send added/removed email for credentials of type &apos;{0}&apos;.
        /// </summary>
        public static string MessageService_CannotSendEmailForCredential {
            get {
                return ResourceManager.GetString("MessageService_CannotSendEmailForCredential", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft account.
        /// </summary>
        public static string MicrosoftAccount_AccountNoun {
            get {
                return ResourceManager.GetString("MicrosoftAccount_AccountNoun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft account.
        /// </summary>
        public static string MicrosoftAccount_Caption {
            get {
                return ResourceManager.GetString("MicrosoftAccount_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sign in with a Microsoft account.
        /// </summary>
        public static string MicrosoftAccount_SignInMessage {
            get {
                return ResourceManager.GetString("MicrosoftAccount_SignInMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing required configuration value: &apos;{0}&apos;.
        /// </summary>
        public static string MissingRequiredConfigurationValue {
            get {
                return ResourceManager.GetString("MissingRequiredConfigurationValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple Credentials match &apos;{0}&apos; credential with Key {1}.
        /// </summary>
        public static string MultipleMatchingCredentials {
            get {
                return ResourceManager.GetString("MultipleMatchingCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Negative indexes are invalid..
        /// </summary>
        public static string NegativeIndexesAreInvalid {
            get {
                return ResourceManager.GetString("NegativeIndexesAreInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ID of your package, &apos;{0}&apos;, is similar to the title of an existing package, which can cause confusion with our users. Please modify the ID of your package and try uploading again..
        /// </summary>
        public static string NewRegistrationIdMatchesExistingPackageTitle {
            get {
                return ResourceManager.GetString("NewRegistrationIdMatchesExistingPackageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No.
        /// </summary>
        public static string No {
            get {
                return ResourceManager.GetString("No", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No credential to remove..
        /// </summary>
        public static string NoCredentialToRemove {
            get {
                return ResourceManager.GetString("NoCredentialToRemove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A nuget package&apos;s {0} property may not be more than {1} characters long..
        /// </summary>
        public static string NuGetPackagePropertyTooLong {
            get {
                return ResourceManager.GetString("NuGetPackagePropertyTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package {0} invalid: the release label can not only contain numerics..
        /// </summary>
        public static string NuGetPackageReleaseVersionContainsOnlyNumerics {
            get {
                return ResourceManager.GetString("NuGetPackageReleaseVersionContainsOnlyNumerics", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package {0} invalid: no &apos;.&apos; allowed in the release label..
        /// </summary>
        public static string NuGetPackageReleaseVersionWithDot {
            get {
                return ResourceManager.GetString("NuGetPackageReleaseVersionWithDot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Package created from API..
        /// </summary>
        public static string PackageCreatedFromApi {
            get {
                return ResourceManager.GetString("PackageCreatedFromApi", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package is invalid and cannot be uploaded. One or more files, such as &apos;{0}&apos; have a date in the future..
        /// </summary>
        public static string PackageEntryFromTheFuture {
            get {
                return ResourceManager.GetString("PackageEntryFromTheFuture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A package with id &apos;{0}&apos; and version &apos;{1}&apos; already exists and cannot be modified..
        /// </summary>
        public static string PackageExistsAndCannotBeModified {
            get {
                return ResourceManager.GetString("PackageExistsAndCannotBeModified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package ID &apos;{0}&apos; is not available..
        /// </summary>
        public static string PackageIdNotAvailable {
            get {
                return ResourceManager.GetString("PackageIdNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package is already curated..
        /// </summary>
        public static string PackageIsAlreadyCurated {
            get {
                return ResourceManager.GetString("PackageIsAlreadyCurated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package is missing required data..
        /// </summary>
        public static string PackageIsMissingRequiredData {
            get {
                return ResourceManager.GetString("PackageIsMissingRequiredData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A package with id &apos;{0}&apos; and version &apos;{1}&apos; does not exist..
        /// </summary>
        public static string PackageWithIdAndVersionNotFound {
            get {
                return ResourceManager.GetString("PackageWithIdAndVersionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No package with this ID exists..
        /// </summary>
        public static string PackageWithIdDoesNotExist {
            get {
                return ResourceManager.GetString("PackageWithIdDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; cannot be null or an empty string.
        /// </summary>
        public static string ParameterCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("ParameterCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your password has been changed..
        /// </summary>
        public static string PasswordChanged {
            get {
                return ResourceManager.GetString("PasswordChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password credentials cannot be used with Authenticate(Credential). Use Authenticate(string, string) instead..
        /// </summary>
        public static string PasswordCredentialsCannotBeUsedHere {
            get {
                return ResourceManager.GetString("PasswordCredentialsCannotBeUsedHere", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your password has been removed.
        /// </summary>
        public static string PasswordRemoved {
            get {
                return ResourceManager.GetString("PasswordRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your password has been set.
        /// </summary>
        public static string PasswordSet {
            get {
                return ResourceManager.GetString("PasswordSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All.
        /// </summary>
        public static string ScopeDescription_All {
            get {
                return ResourceManager.GetString("ScopeDescription_All", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List/unlist package.
        /// </summary>
        public static string ScopeDescription_ListUnlistPackage {
            get {
                return ResourceManager.GetString("ScopeDescription_ListUnlistPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Push new package registration.
        /// </summary>
        public static string ScopeDescription_PushNewPackageRegistration {
            get {
                return ResourceManager.GetString("ScopeDescription_PushNewPackageRegistration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Push package version.
        /// </summary>
        public static string ScopeDescription_PushPackageVersion {
            get {
                return ResourceManager.GetString("ScopeDescription_PushPackageVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown.
        /// </summary>
        public static string ScopeDescription_Unknown {
            get {
                return ResourceManager.GetString("ScopeDescription_Unknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested resource can only be accessed via SSL..
        /// </summary>
        public static string SSLRequired {
            get {
                return ResourceManager.GetString("SSLRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You successfully uploaded {0} {1}..
        /// </summary>
        public static string SuccessfullyUploadedPackage {
            get {
                return ResourceManager.GetString("SuccessfullyUploadedPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The title of your package, &apos;{0}&apos;, is similar to the ID of an existing package, which can cause confusion with our users. Please modify the title of your package and try uploading again..
        /// </summary>
        public static string TitleMatchesExistingRegistration {
            get {
                return ResourceManager.GetString("TitleMatchesExistingRegistration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Token expiration should give the user at least a minute to change their password.
        /// </summary>
        public static string TokenExpirationShouldGiveUser1MinuteToChangePassword {
            get {
                return ResourceManager.GetString("TokenExpirationShouldGiveUser1MinuteToChangePassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User is not authorized.
        /// </summary>
        public static string Unauthorized {
            get {
                return ResourceManager.GetString("Unauthorized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown authentication provider: &apos;{0}&apos;.
        /// </summary>
        public static string UnknownAuthenticationProvider {
            get {
                return ResourceManager.GetString("UnknownAuthenticationProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A package file is required..
        /// </summary>
        public static string UploadFileIsRequired {
            get {
                return ResourceManager.GetString("UploadFileIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file must be a .nupkg file..
        /// </summary>
        public static string UploadFileMustBeNuGetPackage {
            get {
                return ResourceManager.GetString("UploadFileMustBeNuGetPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The NuGet package contains an invalid .nuspec file. The error encountered was:&apos;{0}&apos;. Correct the error and try again..
        /// </summary>
        public static string UploadPackage_InvalidNuspec {
            get {
                return ResourceManager.GetString("UploadPackage_InvalidNuspec", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The NuGet package is invalid. The error encountered was:&apos;{0}&apos;. Correct the error and try again..
        /// </summary>
        public static string UploadPackage_InvalidPackage {
            get {
                return ResourceManager.GetString("UploadPackage_InvalidPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This package requires version &apos;{0}&apos; of NuGet, which this gallery does not currently support. Please contact us if you have questions..
        /// </summary>
        public static string UploadPackage_MinClientVersionOutOfRange {
            get {
                return ResourceManager.GetString("UploadPackage_MinClientVersionOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot reset your password until you confirm your account..
        /// </summary>
        public static string UserIsNotYetConfirmed {
            get {
                return ResourceManager.GetString("UserIsNotYetConfirmed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A user key is required..
        /// </summary>
        public static string UserKeyIsRequired {
            get {
                return ResourceManager.GetString("UserKeyIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A unique user with that username or email address and password does not exist. Try logging on with your username if you were using an email address to log on..
        /// </summary>
        public static string UsernameAndPasswordNotFound {
            get {
                return ResourceManager.GetString("UsernameAndPasswordNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The username &apos;{0}&apos; is not available..
        /// </summary>
        public static string UsernameNotAvailable {
            get {
                return ResourceManager.GetString("UsernameNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A user with the provided user name does not exist..
        /// </summary>
        public static string UserNotFound {
            get {
                return ResourceManager.GetString("UserNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your API key expires in {0} days. Visit {1} to regenerate your API key..
        /// </summary>
        public static string WarningApiKeyAboutToExpire {
            get {
                return ResourceManager.GetString("WarningApiKeyAboutToExpire", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your API key has expired. Visit {0} to generate a new API key..
        /// </summary>
        public static string WarningApiKeyExpired {
            get {
                return ResourceManager.GetString("WarningApiKeyExpired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Yes.
        /// </summary>
        public static string Yes {
            get {
                return ResourceManager.GetString("Yes", resourceCulture);
            }
        }
    }
}
