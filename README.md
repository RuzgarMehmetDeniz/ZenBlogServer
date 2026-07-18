# ZenBlog Server

ZenBlog platformunun backend API'si. Soğan mimarisi (Onion Architecture) prensipleriyle geliştirilmiş, CQRS pattern'i ve MediatR kullanan bir .NET projesidir.

## İçindekiler

- [Mimari](#mimari)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Proje Yapısı](#proje-yapısı)
- [Özellikler](#özellikler)

## Mimari

Proje, katmanlar arası bağımlılığı azaltmak ve iş kurallarını dış katmanlardan (veritabanı, API) izole etmek amacıyla **Soğan Mimarisi (Onion Architecture)** ile tasarlanmıştır.

```
ZenBlogServer
│
├── Core
│   ├── ZenBlog.Domain          → Entity'ler, temel domain kuralları
│   └── ZenBlog.Application     → İş mantığı, CQRS (Command/Query), Handler'lar
│
├── Infrastructure
│   ├── ZenBlog.Infrastructure  → Dış servisler (JWT, vb.)
│   └── ZenBlog.Persistence     → EF Core, Repository, Migration'lar
│
└── Presentation
    └── ZenBlog.API             → Minimal API uç noktaları, middleware'ler
```

Bağımlılıklar her zaman içe doğru akar: `Presentation → Infrastructure → Application → Domain`. `Domain` katmanı hiçbir dış katmana bağımlı değildir.

## Kullanılan Teknolojiler

- **.NET** — Web API
- **Entity Framework Core** — Code First yaklaşımı, Migration desteği
- **MediatR** — CQRS pattern implementasyonu (Command/Query ayrımı)
- **AutoMapper** — Entity ↔ DTO dönüşümleri
- **FluentValidation** — İstek doğrulama, `ValidationBehavior` ile MediatR pipeline'ına entegre
- **JWT (JSON Web Token)** — Kimlik doğrulama ve yetkilendirme
- **Scalar** — API dokümantasyonu (Swagger yerine, Minimal API ile birlikte)
- **SQL Server** — Veritabanı
- **Secret Manager (`secrets.json`)** — Hassas yapılandırma bilgilerinin (connection string, JWT key vb.) kaynak kodun dışında tutulması

## Proje Yapısı

### ZenBlog.Domain
```
Entities/
├── Common/
│   └── BaseEntity.cs
├── AppUser.cs
├── AppRole.cs
├── Blog.cs
├── Category.cs
├── Comment.cs
├── SubComment.cs
├── ContactInfo.cs
├── Message.cs
└── Social.cs
```

### ZenBlog.Application
```
Base/
├── BaseDto.cs
└── BaseResult.cs

Behaviors/
└── ValidationBehavior.cs        → MediatR pipeline'ında otomatik validasyon

Contracts/Persistence/
├── IRepository.cs
├── IUnitOfWork.cs
└── IJwtService.cs

Features/
├── Blogs/
│   ├── Commands/
│   ├── Endpoints/
│   ├── Handlers/
│   ├── Mappings/
│   ├── Queries/
│   ├── Result/
│   └── Validators/
├── Categories/
├── Comments/
├── ContactInfos/
├── Messages/
├── Socials/
└── SubComments/
```

Her özellik (Blogs, Categories vb.) **Vertical Slice** yaklaşımıyla kendi Command, Query, Handler, Endpoint, Mapping ve Validator'larını bir arada barındırır.

### ZenBlog.Persistence
```
Concrete/
├── GenericRepository.cs   → IRepository<T> implementasyonu
├── UnitOfWork.cs
└── JwtService.cs

Context/
└── AppDbContext.cs

Interceptors/
└── AuditDbContextInterceptor.cs   → CreatedAt / UpdatedAt otomatik doldurma

Migrations/
```

### ZenBlog.API
```
CustomMiddlewares/
└── CustomExceptionHandlingMiddleware.cs

Program.cs
appsettings.json
```

Bu projede klasik MVC Controller'lar kullanılmamıştır; uç noktalar **Minimal API** yaklaşımıyla `Endpoints` klasörlerinde özellik bazlı gruplanmıştır.

## Özellikler

- **CQRS** — Okuma (Query) ve yazma (Command) işlemleri ayrı sınıflarla yönetilir
- **Generic Repository + Unit of Work** — Veri erişim katmanında tekrar eden kodu azaltır
- **Otomatik doğrulama** — FluentValidation kuralları, `ValidationBehavior` sayesinde her istek MediatR pipeline'ından geçerken otomatik çalışır
- **Merkezi hata yönetimi** — `CustomExceptionHandlingMiddleware` ile tüm hatalar tek bir noktadan, tutarlı bir formatta döner
- **Audit alanları** — `AuditDbContextInterceptor`, entity'lerin `CreatedAt`/`UpdatedAt` alanlarını otomatik olarak doldurur
- **JWT tabanlı kimlik doğrulama**
- **Kategori, blog, yorum, alt yorum, iletişim bilgisi, mesaj ve sosyal medya** yönetimi için uçtan uca CRUD işlemleri


Bu API'nin Angular tabanlı istemcisi için: [ZenBlogClient](https://github.com/RuzgarMehmetDeniz/ZenBlogClient)

## Lisans

Bu proje kişisel/eğitim amaçlı geliştirilmiştir.
