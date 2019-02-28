USE [llpdb]
GO
/***** Object:  Table [dbo].[Chapter]    Script Date: 2/14/2018 6:01:02 PM *****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chapter](
 [Id] [int] IDENTITY(1,1) NOT NULL,
 [ChapterNo] [nvarchar](50) NULL,
 [Name] [nvarchar](500) NULL,
 [Type] [nvarchar](50) NULL,
 [Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Chapter] PRIMARY KEY CLUSTERED 
(
 [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/***** Object:  Table [dbo].[ChapterContent]    Script Date: 2/14/2018 6:01:02 PM *****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChapterContent](
 [Id] [int] IDENTITY(1,1) NOT NULL,
 [TitleNo] [nvarchar](50) NOT NULL,
 [Title] [nvarchar](500) NOT NULL,
 [CpContent] [nvarchar](max) NULL,
 [ChapterId] [int] NULL,
 [ParentId] [int] NULL,
 CONSTRAINT [PK_ChapterContent] PRIMARY KEY CLUSTERED 
(
 [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO