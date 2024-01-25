Public Class IndustryIdentifier
    Public Property type As String
    Public Property identifier As String
End Class

Public Class ReadingModes
    Public Property text As Boolean
    Public Property image As Boolean
End Class

Public Class PanelizationSummary
    Public Property containsEpubBubbles As Boolean
    Public Property containsImageBubbles As Boolean
End Class

Public Class ImageLinks
    Public Property smallThumbnail As String
    Public Property thumbnail As String
End Class

Public Class VolumeInfo
    Public Property title As String
    Public Property subtitle As String
    Public Property authors As String()
    Public Property publisher As String
    Public Property publishedDate As String
    Public Property industryIdentifiers As IndustryIdentifier()
    Public Property readingModes As ReadingModes
    Public Property pageCount As Integer
    Public Property printType As String
    Public Property averageRating As Double
    Public Property ratingsCount As Integer
    Public Property maturityRating As String
    Public Property allowAnonLogging As Boolean
    Public Property contentVersion As String
    Public Property panelizationSummary As PanelizationSummary
    Public Property imageLinks As ImageLinks
    Public Property language As String
    Public Property previewLink As String
    Public Property infoLink As String
    Public Property canonicalVolumeLink As String
    Public Property description As String
    Public Property categories As String()
End Class

Public Class ListPrice
    Public Property amount As Double
    Public Property currencyCode As String
End Class

Public Class RetailPrice
    Public Property amount As Double
    Public Property currencyCode As String
End Class

Public Class RentalDuration
    Public Property unit As String
    Public Property count As Integer
End Class

Public Class Offer
    Public Property finskyOfferType As Integer
    Public Property listPrice As ListPrice
    Public Property retailPrice As RetailPrice
    Public Property giftable As Boolean
    Public Property rentalDuration As RentalDuration
End Class

Public Class SaleInfo
    Public Property country As String
    Public Property saleability As String
    Public Property isEbook As Boolean
    Public Property listPrice As ListPrice
    Public Property retailPrice As RetailPrice
    Public Property buyLink As String
    Public Property offers As Offer()
End Class

Public Class Epub
    Public Property isAvailable As Boolean
End Class

Public Class Pdf
    Public Property isAvailable As Boolean
    Public Property acsTokenLink As String
End Class

Public Class AccessInfo
    Public Property country As String
    Public Property viewability As String
    Public Property embeddable As Boolean
    Public Property publicDomain As Boolean
    Public Property textToSpeechPermission As String
    Public Property epub As Epub
    Public Property pdf As Pdf
    Public Property webReaderLink As String
    Public Property accessViewStatus As String
    Public Property quoteSharingAllowed As Boolean
End Class

Public Class SearchInfo
    Public Property textSnippet As String
End Class

Public Class Item
    Public Property kind As String
    Public Property id As String
    Public Property etag As String
    Public Property selfLink As String
    Public Property volumeInfo As VolumeInfo
    Public Property saleInfo As SaleInfo
    Public Property accessInfo As AccessInfo
    Public Property searchInfo As SearchInfo
End Class

Public Class BooksResult
    Public Property kind As String
    Public Property totalItems As Integer
    Public Property items As Item()
End Class