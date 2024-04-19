﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsAggregator.EF;

namespace NewsAggregator.ML.Startup.Migrations
{
    [DbContext(typeof(NewsAggregatorDBContext))]
    [Migration("20210526130015_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewsAggregator.Core.Domains.Articles.ArticleAggregate", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataSourceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbLikes")
                        .HasColumnType("int");

                    b.Property<int>("NbRead")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("PublishDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Articles.ArticleLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActionDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ArticleAggregateId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleAggregateId");

                    b.ToTable("ArticleLike");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Articles.ArticleRead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActionDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ArticleAggregateId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsHidden")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleAggregateId");

                    b.ToTable("ArticleRead");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.DataSources.DataSourceAggregate", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbFollowers")
                        .HasColumnType("int");

                    b.Property<int>("NbStoriesPerMonth")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DataSources");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.DataSources.DataSourceArticle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataSourceAggregateId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("NbArticles")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DataSourceAggregateId");

                    b.ToTable("DataSourceArticle");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.DataSources.DataSourceExtractionHistory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DataSourceAggregateId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("LastArticlePublicationDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("NbExtractedArticle")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DataSourceAggregateId");

                    b.ToTable("DataSourceExtractionHistory");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.DataSources.DataSourceTopic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataSourceAggregateId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Nb")
                        .HasColumnType("int");

                    b.Property<string>("TopicName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DataSourceAggregateId");

                    b.ToTable("DataSourceTopic");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Feeds.FeedAggregate", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Feeds");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Feeds.FeedDatasource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DatasourceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeedAggregateId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("FeedAggregateId");

                    b.ToTable("FeedDatasource");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Recommendations.RecommendationAggregate", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Recommendations");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Recommendations.RecommendationArticle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArticleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecommendationAggregateId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("RecommendationAggregateId");

                    b.ToTable("RecommendationArticle");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Sessions.SessionAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActionDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ArticleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArticleLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InteractionType")
                        .HasColumnType("int");

                    b.Property<string>("SessionAggregateId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SessionAggregateId");

                    b.ToTable("SessionAction");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Sessions.SessionAggregate", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Articles.ArticleLike", b =>
                {
                    b.HasOne("NewsAggregator.Core.Domains.Articles.ArticleAggregate", null)
                        .WithMany("ArticleLikeLst")
                        .HasForeignKey("ArticleAggregateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Articles.ArticleRead", b =>
                {
                    b.HasOne("NewsAggregator.Core.Domains.Articles.ArticleAggregate", null)
                        .WithMany("ArticleReadLst")
                        .HasForeignKey("ArticleAggregateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.DataSources.DataSourceArticle", b =>
                {
                    b.HasOne("NewsAggregator.Core.Domains.DataSources.DataSourceAggregate", null)
                        .WithMany("Articles")
                        .HasForeignKey("DataSourceAggregateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.DataSources.DataSourceExtractionHistory", b =>
                {
                    b.HasOne("NewsAggregator.Core.Domains.DataSources.DataSourceAggregate", null)
                        .WithMany("ExtractionHistories")
                        .HasForeignKey("DataSourceAggregateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.DataSources.DataSourceTopic", b =>
                {
                    b.HasOne("NewsAggregator.Core.Domains.DataSources.DataSourceAggregate", null)
                        .WithMany("Topics")
                        .HasForeignKey("DataSourceAggregateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Feeds.FeedDatasource", b =>
                {
                    b.HasOne("NewsAggregator.Core.Domains.Feeds.FeedAggregate", null)
                        .WithMany("DataSources")
                        .HasForeignKey("FeedAggregateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Recommendations.RecommendationArticle", b =>
                {
                    b.HasOne("NewsAggregator.Core.Domains.Recommendations.RecommendationAggregate", null)
                        .WithMany("Articles")
                        .HasForeignKey("RecommendationAggregateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Sessions.SessionAction", b =>
                {
                    b.HasOne("NewsAggregator.Core.Domains.Sessions.SessionAggregate", null)
                        .WithMany("Actions")
                        .HasForeignKey("SessionAggregateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Articles.ArticleAggregate", b =>
                {
                    b.Navigation("ArticleLikeLst");

                    b.Navigation("ArticleReadLst");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.DataSources.DataSourceAggregate", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("ExtractionHistories");

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Feeds.FeedAggregate", b =>
                {
                    b.Navigation("DataSources");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Recommendations.RecommendationAggregate", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("NewsAggregator.Core.Domains.Sessions.SessionAggregate", b =>
                {
                    b.Navigation("Actions");
                });
#pragma warning restore 612, 618
        }
    }
}
