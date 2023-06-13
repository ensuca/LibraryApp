LibraryApp Yazılım Dökümantasyonu

İçindekiler

Giriş
Proje Açıklaması
Kullanılan Teknolojiler
Sistem Mimarisi
Genel Bakış
Modüller ve Sınıflar
Kurulum ve Konfigürasyon
Gereksinimler
Kurulum Adımları



1. Giriş
Proje Açıklaması
LibraryApp, bir kütüphane yönetim uygulamasıdır. Bu uygulama, kullanıcıların kütüphane koleksiyonunu arama, kitapları ödünç alma, kullanıcı profillerini yönetme gibi işlevleri gerçekleştirmelerine olanak tanır. Uygulama, kullanıcı dostu arayüzü ve verimli veritabanı yönetimiyle kullanıcıların kütüphane işlemlerini kolaylıkla yapmasını sağlar.

Kullanılan Teknolojiler
LibraryApp projesi, aşağıdaki teknolojileri kullanmaktadır:

Programlama Dili: C#
Kullanıcı Arayüzü: Windows Forms
Veritabanı: SQLite








2. Sistem Mimarisi

Genel Bakış

LibraryApp projesi, katmanlı bir mimari yapısına sahiptir. Aşağıdaki modüllerden oluşur:

Kullanıcı Yönetimi Modülü: Kullanıcı girişi, kullanıcı kaydı, profil yönetimi gibi işlemleri gerçekleştirir.
Kitap Yönetimi Modülü: Kitap arama, kitap detayları, ödünç alma gibi işlemleri sağlar.
Veritabanı Modülü: Veri tabanı bağlantısı ve veritabanı işlemlerini yönetir.
Modüller ve Sınıflar
Kullanıcı Yönetimi Modülü:

LoginScreen: Kullanıcı giriş ekranını temsil eder.
RegistrationScreen: Kullanıcı kayıt ekranını temsil eder.
UserProfileScreen: Kullanıcı profil ekranını temsil eder.
Kitap Yönetimi Modülü:

SearchBooksScreen: Kitap arama ekranını temsil eder.
BookDetailsScreen: Kitap detayları ekranını temsil eder.
BorrowBookScreen: Kitap ödünç alma ekranını temsil eder.
Veritabanı Modülü:

DatabaseConnection: Veritabanı bağlantısını yönetir.
UserRepository: Kullanıcı verilerinin veritabanıyla iletişimini sağlar.
BookRepository: Kitap verilerinin veritabanıyla iletişimini sağlar.

3. Kurulum ve Konfigürasyon

Gereksinimler

LibraryApp projesini kullanabilmek için aşağıdaki gereksinimlere ihtiyaç vardır:

Windows işletim sistemi (Windows 7 veya üzeri)
.NET Framework 4.5 veya üzeri sürümü
Kurulum Adımları
LibraryApp projesini indirin veya kopyalayın.
Visual Studio IDE'sini açın.
Proje dosyasını Visual Studio'da açın.
Gerekli bağımlılıkları yükleyin.
Proje derleyin ve çalıştırın.



## ENGLİSH
Table of Contents

Introduction
Project Description
Technologies Used
System Architecture
Overview
Modules and Classes
Installation and Configuration
Requirements
Installation Steps

Introduction
Project Description
LibraryApp is a library management application. This application allows users to perform functions such as searching the library collection, borrowing books, and managing user profiles. The application facilitates users' library transactions with its user-friendly interface and efficient database management.
Technologies Used
The LibraryApp project uses the following technologies:

Programming Language: C#
User Interface: Windows Forms
Database: SQLite

System Architecture
Overview

The LibraryApp project has a layered architectural structure. It consists of the following modules:

User Management Module: Performs operations such as user login, user registration, and profile management.
Book Management Module: Provides functionalities for book search, book details, and borrowing books.
Database Module: Manages the database connection and database operations.
Modules and Classes
User Management Module:

LoginScreen: Represents the user login screen.
RegistrationScreen: Represents the user registration screen.
UserProfileScreen: Represents the user profile screen.
Book Management Module:

SearchBooksScreen: Represents the book search screen.
BookDetailsScreen: Represents the book details screen.
BorrowBookScreen: Represents the book borrowing screen.
Database Module:

DatabaseConnection: Manages the database connection.
UserRepository: Facilitates communication between user data and the database.
BookRepository: Facilitates communication between book data and the database.

Installation and Configuration
Requirements

To use the LibraryApp project, the following requirements must be met:

Windows operating system (Windows 7 or above)
.NET Framework 4.5 or above
Installation Steps
Download or copy the LibraryApp project.
Open the Visual Studio IDE.
Open the project file in Visual Studio.
Install the required dependencies.
Compile and run the project."
