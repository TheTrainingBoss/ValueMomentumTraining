## Content DTO types:
- PageNodeDto - Pages
- NewsDto - News
- BlogDto - Blogs
- BlogPostDto - Blog posts
-EventDto - Event
- LibraryDto - Library
- ImageDto - Image
- DocumentDto - Document
- VideoDto - Video
- ListDto - List
- ListItemDto - List item
- FormDto - Form
- ContentItemDto - Content block
- TagDto - Tag
- CategoryDto - Category

## Base DTO types
- SdkItem - Base object. All DTOs in this list inherit directly or indirectly this type. Used also for dynamic content.
- ContentBaseDto - Inherited by NewsDto, MediaDto, ContentWithParentDto
- ContentWithParentDto - Inherited by BlogPostDto, EventDto
- MediaDto - Inherited by ImageDto, DocumentDto, VideoDto
- TaxonDto - Inherited by CategoryDto, TagDto

## Misc DTO types
- SiteDto - Site
- PageTemplateDto - Page template
- TaxonomyDto - Taxonomy
- UserDto - User
- CalendarDto - Calendar