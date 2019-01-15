// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Group.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Group : DirectoryObject
    {
    
        /// <summary>
        /// Gets or sets classification.
        /// Describes a classification for the group (such as low, medium or high business impact). Valid values for this property are defined by creating a ClassificationList setting value, based on the template definition.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "classification", Required = Newtonsoft.Json.Required.Default)]
        public string Classification { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Timestamp of when the group was created. The value cannot be modified and is automatically populated when the group is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// An optional description for the group.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the group. This property is required when a group is created and it cannot be cleared during updates. Supports $filter and $orderby.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets group types.
        /// Specifies the type of group to create. Possible values are Unified to create an Office 365 group, or DynamicMembership for dynamic groups.  For all other group types, like security-enabled groups and email-enabled security groups, do not set this property. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupTypes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> GroupTypes { get; set; }
    
        /// <summary>
        /// Gets or sets mail.
        /// The SMTP address for the group, for example, 'serviceadmins@contoso.onmicrosoft.com'. Read-only. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mail", Required = Newtonsoft.Json.Required.Default)]
        public string Mail { get; set; }
    
        /// <summary>
        /// Gets or sets mail enabled.
        /// Specifies whether the group is mail-enabled. If the securityEnabled property is also true, the group is a mail-enabled security group; otherwise, the group is a Microsoft Exchange distribution group.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? MailEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets mail nickname.
        /// The mail alias for the group, unique in the organization. This property must be specified when a group is created. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailNickname", Required = Newtonsoft.Json.Required.Default)]
        public string MailNickname { get; set; }
    
        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// Indicates the last time at which the group was synced with the on-premises directory.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesLastSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets on premises provisioning errors.
        /// Errors when using Microsoft synchronization product during provisioning.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesProvisioningErrors", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<OnPremisesProvisioningError> OnPremisesProvisioningErrors { get; set; }
    
        /// <summary>
        /// Gets or sets on premises security identifier.
        /// Contains the on-premises security identifier (SID) for the group that was synchronized from on-premises to the cloud. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesSecurityIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string OnPremisesSecurityIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// true if this group is synced from an on-premises directory; false if this group was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesSyncEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? OnPremisesSyncEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets proxy addresses.
        /// The any operator is required for filter expressions on multi-valued properties. Read-only. Not nullable. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxyAddresses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ProxyAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets renewed date time.
        /// Timestamp of when the group was last renewed. This cannot be modified directly and is only updated via the renew service action. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "renewedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? RenewedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets security enabled.
        /// Specifies whether the group is a security group. If the mailEnabled property is also true, the group is a mail-enabled security group; otherwise it is a security group. Must be false for Office 365 groups. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets visibility.
        /// Specifies the visibility of an Office 365 group. Possible values are: private, public, or hiddenmembership; blank values are treated as public.  See Group visibility options to learn more.Visibility can be set only when a group is created; it is not editable.Visibility is supported only for unified groups; it is not supported for security groups.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "visibility", Required = Newtonsoft.Json.Required.Default)]
        public string Visibility { get; set; }
    
        /// <summary>
        /// Gets or sets allow external senders.
        /// Default is false. Indicates if people external to the organization can send messages to the group.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowExternalSenders", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowExternalSenders { get; set; }
    
        /// <summary>
        /// Gets or sets auto subscribe new members.
        /// Default is false. Indicates if new members added to the group will be auto-subscribed to receive email notifications. You can set this property in a PATCH request for the group; do not set it in the initial POST request that creates the group.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "autoSubscribeNewMembers", Required = Newtonsoft.Json.Required.Default)]
        public bool? AutoSubscribeNewMembers { get; set; }
    
        /// <summary>
        /// Gets or sets is subscribed by mail.
        /// Default value is true. Indicates whether the current user is subscribed to receive email conversations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isSubscribedByMail", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsSubscribedByMail { get; set; }
    
        /// <summary>
        /// Gets or sets unseen count.
        /// Count of conversations that have been delivered one or more new posts since the signed-in user's last visit to the group.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unseenCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UnseenCount { get; set; }
    
        /// <summary>
        /// Gets or sets is archived.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isArchived", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsArchived { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// Users and groups that are members of this group. HTTP Methods: GET (supported for all groups), POST (supported for Office 365 groups, security groups and mail-enabled security groups), DELETE (supported for Office 365 groups and security groups) Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "members", Required = Newtonsoft.Json.Required.Default)]
        public IGroupMembersCollectionWithReferencesPage Members { get; set; }
    
        /// <summary>
        /// Gets or sets member of.
        /// Groups that this group is a member of. HTTP Methods: GET (supported for all groups). Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "memberOf", Required = Newtonsoft.Json.Required.Default)]
        public IGroupMemberOfCollectionWithReferencesPage MemberOf { get; set; }
    
        /// <summary>
        /// Gets or sets transitive members.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transitiveMembers", Required = Newtonsoft.Json.Required.Default)]
        public IGroupTransitiveMembersCollectionWithReferencesPage TransitiveMembers { get; set; }
    
        /// <summary>
        /// Gets or sets transitive member of.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transitiveMemberOf", Required = Newtonsoft.Json.Required.Default)]
        public IGroupTransitiveMemberOfCollectionWithReferencesPage TransitiveMemberOf { get; set; }
    
        /// <summary>
        /// Gets or sets created on behalf of.
        /// The user (or application) that created the group. NOTE: This is not set if the user is an administrator. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdOnBehalfOf", Required = Newtonsoft.Json.Required.Default)]
        public DirectoryObject CreatedOnBehalfOf { get; set; }
    
        /// <summary>
        /// Gets or sets owners.
        /// The owners of the group. The owners are a set of non-admin users who are allowed to modify this object. Limited to 10 owners. HTTP Methods: GET (supported for all groups), POST (supported for Office 365 groups, security groups and mail-enabled security groups), DELETE (supported for Office 365 groups and security groups). Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "owners", Required = Newtonsoft.Json.Required.Default)]
        public IGroupOwnersCollectionWithReferencesPage Owners { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settings", Required = Newtonsoft.Json.Required.Default)]
        public IGroupSettingsCollectionPage Settings { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the group. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensions", Required = Newtonsoft.Json.Required.Default)]
        public IGroupExtensionsCollectionPage Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets threads.
        /// The group's conversation threads. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "threads", Required = Newtonsoft.Json.Required.Default)]
        public IGroupThreadsCollectionPage Threads { get; set; }
    
        /// <summary>
        /// Gets or sets calendar.
        /// The group's calendar. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendar", Required = Newtonsoft.Json.Required.Default)]
        public Calendar Calendar { get; set; }
    
        /// <summary>
        /// Gets or sets calendar view.
        /// The calendar view for the calendar. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendarView", Required = Newtonsoft.Json.Required.Default)]
        public IGroupCalendarViewCollectionPage CalendarView { get; set; }
    
        /// <summary>
        /// Gets or sets events.
        /// The group's calendar events.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "events", Required = Newtonsoft.Json.Required.Default)]
        public IGroupEventsCollectionPage Events { get; set; }
    
        /// <summary>
        /// Gets or sets conversations.
        /// The group's conversations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conversations", Required = Newtonsoft.Json.Required.Default)]
        public IGroupConversationsCollectionPage Conversations { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
        /// The group's profile photo
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "photo", Required = Newtonsoft.Json.Required.Default)]
        public ProfilePhoto Photo { get; set; }
    
        /// <summary>
        /// Gets or sets photos.
        /// The profile photos owned by the group. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "photos", Required = Newtonsoft.Json.Required.Default)]
        public IGroupPhotosCollectionPage Photos { get; set; }
    
        /// <summary>
        /// Gets or sets accepted senders.
        /// The list of users or groups that are allowed to create post's or calendar events in this group. If this list is non-empty then only users or groups listed here are allowed to post.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "acceptedSenders", Required = Newtonsoft.Json.Required.Default)]
        public IGroupAcceptedSendersCollectionPage AcceptedSenders { get; set; }
    
        /// <summary>
        /// Gets or sets rejected senders.
        /// The list of users or groups that are not allowed to create posts or calendar events in this group. Nullable
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rejectedSenders", Required = Newtonsoft.Json.Required.Default)]
        public IGroupRejectedSendersCollectionPage RejectedSenders { get; set; }
    
        /// <summary>
        /// Gets or sets drive.
        /// The group's default drive. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "drive", Required = Newtonsoft.Json.Required.Default)]
        public Drive Drive { get; set; }
    
        /// <summary>
        /// Gets or sets drives.
        /// The group's drives. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "drives", Required = Newtonsoft.Json.Required.Default)]
        public IGroupDrivesCollectionPage Drives { get; set; }
    
        /// <summary>
        /// Gets or sets sites.
        /// The list of SharePoint sites in this group. Access the default site with /sites/root.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sites", Required = Newtonsoft.Json.Required.Default)]
        public IGroupSitesCollectionPage Sites { get; set; }
    
        /// <summary>
        /// Gets or sets planner.
        /// Entry-point to Planner resource that might exist for a Unified Group.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "planner", Required = Newtonsoft.Json.Required.Default)]
        public PlannerGroup Planner { get; set; }
    
        /// <summary>
        /// Gets or sets onenote.
        /// Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onenote", Required = Newtonsoft.Json.Required.Default)]
        public Onenote Onenote { get; set; }
    
        /// <summary>
        /// Gets or sets group lifecycle policies.
        /// The collection of lifecycle policies for this group. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupLifecyclePolicies", Required = Newtonsoft.Json.Required.Default)]
        public IGroupGroupLifecyclePoliciesCollectionPage GroupLifecyclePolicies { get; set; }
    
        /// <summary>
        /// Gets or sets team.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "team", Required = Newtonsoft.Json.Required.Default)]
        public Team Team { get; set; }
    
    }
}

