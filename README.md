# Portal Duplicator
Douplicates a Portal365 by createing exact copy of Configuration Migration tool data file. References are respected.

This tool designed for XrmToolBox

   The duplication works based on [Configuration Migration tool (free, part of Xrm SDK)](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/admin/manage-configuration-data) 
Couple of ready [schemas](https://github.com/mkalinov/Portals365_PortalDuplicator/tree/master/PortalDuplicator/DataUtilitySchemas)
are included in the solution to give an idea “how to”.
       Use the “WebFilesAttachmentsCopier” and/or “AttachmentsReversibleCopy” to sync web files attachments and Site Setting.

What’s the point? 
-	Portal deployment
-	Portal backup
-	Deployment of multiple versions of the same portal with option to switch between them – saves money by  reducing the number of environments and portals 
-	No AD or B2C sync required – duplicated portal uses same contact 
Tested for crm 8.2- 9.1. Portals 8.4 – 9.x.


## Related links:

[Configuration Migration Tool - MS SDK](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/admin/manage-configuration-data)
[DMM365]( https://github.com/mkalinov/DMM365)
[Portal 365 WebFiles Attachments Copier](https://github.com/mkalinov/Portal365_WebFilesAttachmentsCopier)

## Recomended blogs:

[Adxstudio Portal how to: Incremental (Sequential) Deployment and backup. Part I](https://crmfield.blogspot.com/2016/01/adxstudio-portal-how-to-incremental.html)
[Fixing issues with migrating Adxstudio/CRM Portal v8 using Configuration Migration tool](https://bernado-nguyen-hoan.com/2017/09/26/fixing-issues-with-migrating-adxstudiocrm-portal-v8-using-configuration-migration-tool/)

## License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT) 

