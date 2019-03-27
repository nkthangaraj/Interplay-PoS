using io.cloudloom.interplay.pos.Proxy.Services;
using Proxy.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.CustomControls;
using io.cloudloom.interplay.pos.Proxy.Contracts.Catalogue;
using UI.Storage;
using UI;

namespace io.cloudloom.interplay.pos.ui
{
    public partial class interplayMainForm : Form
    {
        public interplayMainForm()
        {
            InitializeComponent();
            CreateCatalogueButtons();
        }

        static interplayMainForm()
        {
            InterplayStorage.Catalogues = GetCatalogue();
        }

        static List<Catalog> GetCatalogue()
        {
            CatalogueService service = new CatalogueService();
            List<Catalog> catalogs = service.GetCatalogue()._embedded.catalogs;
            //List<Catalog> catalogs = new List<Catalog>
            //{
            //    new Catalog
            //    {
            //        name = "Catalogue1",
            //        _links = null,
            //        productEntries = new List<ProductEntry>
            //        {
            //            new ProductEntry
            //            {
            //                name = "C1_PE1",
            //                description = "C1_PE1",
            //                articleEntries = new List<ArticleEntry>
            //                {
            //                    new ArticleEntry
            //                    {
            //                        name = "C1_PE1_AE1",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE1_AE1_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE1_AE1_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C1_PE1_AE1_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C1_PE1_AE2",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE1_AE2_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE1_AE2_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C1_PE1_AE2_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C1_PE1_AE3",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE1_AE3_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE1_AE3_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C1_PE1_AE3_SA3"
            //                           }
            //                        }
            //                    }
            //                }
            //            },
            //            new ProductEntry
            //            {
            //                name = "C1_PE2",
            //                description = "C1_PE2",
            //                articleEntries = new List<ArticleEntry>
            //                {
            //                    new ArticleEntry
            //                    {
            //                        name = "C1_PE2_AE1",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE2_AE1_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE2_AE1_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C1_PE2_AE1_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C1_PE2_AE2",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE2_AE2_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE2_AE2_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C1_PE2_AE2_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C1_PE2_AE3",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE2_AE3_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE2_AE3_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C1_PE2_AE3_SA3"
            //                           }
            //                        }
            //                    }
            //                }
            //            },
            //            new ProductEntry
            //            {
            //                name = "C1_PE3",
            //                description = "C1_PE3",
            //                articleEntries = new List<ArticleEntry>
            //                {
            //                    new ArticleEntry
            //                    {
            //                        name = "C1_PE3_AE1",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE3_AE1_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE3_AE1_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C1_PE3_AE1_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C1_PE3_AE2",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE3_AE2_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE3_AE2_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C1_PE3_AE2_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C1_PE3_AE3",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE3_AE3_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C1_PE3_AE3_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C1_PE3_AE3_SA3"
            //                           }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    },
            //    new Catalog
            //    {
            //        name = "Catalogue2",
            //        _links = null,
            //        productEntries = new List<ProductEntry>
            //        {
            //            new ProductEntry
            //            {
            //                name = "C2_PE1",
            //                description = "C2_PE1",
            //                articleEntries = new List<ArticleEntry>
            //                {
            //                    new ArticleEntry
            //                    {
            //                        name = "C2_PE1_AE1",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE1_AE1_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE1_AE1_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C2_PE1_AE1_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C2_PE1_AE2",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE1_AE2_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE1_AE2_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C2_PE1_AE2_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C2_PE1_AE3",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE1_AE3_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE1_AE3_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C2_PE1_AE3_SA3"
            //                           }
            //                        }
            //                    }
            //                }
            //            },
            //            new ProductEntry
            //            {
            //                name = "C2_PE2",
            //                description = "C2_PE2",
            //                articleEntries = new List<ArticleEntry>
            //                {
            //                    new ArticleEntry
            //                    {
            //                        name = "C2_PE2_AE1",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE2_AE1_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE2_AE1_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C2_PE2_AE1_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C2_PE2_AE2",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE2_AE2_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE2_AE2_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C2_PE2_AE2_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C2_PE2_AE3",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE2_AE3_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE2_AE3_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C2_PE2_AE3_SA3"
            //                           }
            //                        }
            //                    }
            //                }
            //            },
            //            new ProductEntry
            //            {
            //                name = "C2_PE3",
            //                description = "C2_PE3",
            //                articleEntries = new List<ArticleEntry>
            //                {
            //                    new ArticleEntry
            //                    {
            //                        name = "C2_PE3_AE1",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE3_AE1_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE3_AE1_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C2_PE3_AE1_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C2_PE3_AE2",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE3_AE2_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE3_AE2_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C2_PE3_AE2_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C2_PE3_AE3",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE3_AE3_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C2_PE3_AE3_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C2_PE3_AE3_SA3"
            //                           }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    },
            //    new Catalog
            //    {
            //        name = "Catalogue3",
            //        _links = null,
            //        productEntries = new List<ProductEntry>
            //        {
            //            new ProductEntry
            //            {
            //                name = "C3_PE1",
            //                description = "C3_PE1",
            //                articleEntries = new List<ArticleEntry>
            //                {
            //                    new ArticleEntry
            //                    {
            //                        name = "C3_PE1_AE1",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE1_AE1_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE1_AE1_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C3_PE1_AE1_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C3_PE1_AE2",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE1_AE2_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE1_AE2_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C3_PE1_AE2_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C3_PE1_AE3",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE1_AE3_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE1_AE3_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C3_PE1_AE3_SA3"
            //                           }
            //                        }
            //                    }
            //                }
            //            },
            //            new ProductEntry
            //            {
            //                name = "C3_PE2",
            //                description = "C3_PE2",
            //                articleEntries = new List<ArticleEntry>
            //                {
            //                    new ArticleEntry
            //                    {
            //                        name = "C3_PE2_AE1",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE2_AE1_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE2_AE1_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C3_PE2_AE1_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C3_PE2_AE2",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE2_AE2_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE2_AE2_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C3_PE2_AE2_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C3_PE2_AE3",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE2_AE3_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE2_AE3_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C3_PE2_AE3_SA3"
            //                           }
            //                        }
            //                    }
            //                }
            //            },
            //            new ProductEntry
            //            {
            //                name = "C3_PE3",
            //                description = "C3_PE3",
            //                articleEntries = new List<ArticleEntry>
            //                {
            //                    new ArticleEntry
            //                    {
            //                        name = "C3_PE3_AE1",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE3_AE1_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE3_AE1_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C3_PE3_AE1_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C3_PE3_AE2",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE3_AE2_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE3_AE2_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C3_PE3_AE2_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C3_PE3_AE3",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE3_AE3_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C3_PE3_AE3_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C3_PE3_AE3_SA3"
            //                           }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    },
            //    new Catalog
            //    {
            //        name = "Catalogue4",
            //        _links = null,
            //        productEntries = new List<ProductEntry>
            //        {
            //            new ProductEntry
            //            {
            //                name = "C4_PE1",
            //                description = "C4_PE1",
            //                articleEntries = new List<ArticleEntry>
            //                {
            //                    new ArticleEntry
            //                    {
            //                        name = "C4_PE1_AE1",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE1_AE1_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE1_AE1_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C4_PE1_AE1_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C4_PE1_AE2",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE1_AE2_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE1_AE2_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C4_PE1_AE2_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C4_PE1_AE3",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE1_AE3_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE1_AE3_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C4_PE1_AE3_SA3"
            //                           }
            //                        }
            //                    }
            //                }
            //            },
            //            new ProductEntry
            //            {
            //                name = "C4_PE2",
            //                description = "C4_PE2",
            //                articleEntries = new List<ArticleEntry>
            //                {
            //                    new ArticleEntry
            //                    {
            //                        name = "C4_PE2_AE1",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE2_AE1_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE2_AE1_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C4_PE2_AE1_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C4_PE2_AE2",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE2_AE2_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE2_AE2_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C4_PE2_AE2_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C4_PE2_AE3",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE2_AE3_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE2_AE3_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C4_PE2_AE3_SA3"
            //                           }
            //                        }
            //                    }
            //                }
            //            },
            //            new ProductEntry
            //            {
            //                name = "C4_PE3",
            //                description = "C4_PE3",
            //                articleEntries = new List<ArticleEntry>
            //                {
            //                    new ArticleEntry
            //                    {
            //                        name = "C4_PE3_AE1",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE3_AE1_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE3_AE1_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C4_PE3_AE1_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C4_PE3_AE2",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE3_AE2_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE3_AE2_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C4_PE3_AE2_SA3"
            //                           }
            //                        }
            //                    },
            //                    new ArticleEntry
            //                    {
            //                        name = "C4_PE3_AE3",
            //                        simpleArticles = new List<SimpleArticle>
            //                        {
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE3_AE3_SA1"
            //                           },
            //                           new SimpleArticle
            //                           {
            //                               name = "C4_PE3_AE3_SA2"
            //                           },
            //                            new SimpleArticle
            //                           {
            //                               name = "C4_PE3_AE3_SA3"
            //                           }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    },
            //};

            return catalogs;

        }

        private void CreateCatalogueButtons()
        {
            foreach (Catalog catalog in InterplayStorage.Catalogues)
            {
                //InterPlayPOSButton button = new InterPlayPOSButton();
                InterPlayPOSCatalogueButton button = new InterPlayPOSCatalogueButton();
                button.catalogue = catalog;
                button.Text = catalog.name;
                button.Click += Catalogue_Button_Click;
                flowLayoutPanelCatagory.Controls.Add(button);
            }
        }

        private void Catalogue_Button_Click(object sender, EventArgs e)
        {
            InterplayStorage.SelectedCatalog = InterplayStorage.Catalogues
                .Where(catalogue => catalogue.name == (((InterPlayPOSCatalogueButton)sender).Text)).FirstOrDefault();

            this.CreateProductButtons();
        }

        private void CreateProductButtons()
        {
            flowLayoutPanelProducts.Controls.Clear();
            flowLayoutPanelArticle.Controls.Clear();

            List<ProductEntry> productEntries = this.GetProductEntries();

                foreach (ProductEntry product in productEntries)
                {
                    InterPlayPOSProductEntryButton button = new InterPlayPOSProductEntryButton();
                    button.Text = product.name;
                    button.Click += Product_Button_Click;
                    flowLayoutPanelProducts.Controls.Add(button);
                }
            }


        private List<ProductEntry> GetProductEntries()
        {
            List<ProductEntry> productEntries = new List<ProductEntry>();

            Catalog catalog = InterplayStorage.Catalogues
                .Where(catalogue => catalogue.name == InterplayStorage.SelectedCatalog.name).FirstOrDefault();

            if (catalog != null)
            {
                productEntries = catalog.productEntries;
            }

            return productEntries;
        }

        private void Product_Button_Click(object sender, EventArgs e)
        {
            this.SetSelectedProductEntry(((InterPlayPOSProductEntryButton)sender).Text);
            this.CreateArticlebuttons();
        }

        private void SetSelectedProductEntry(string selectedProduct)
        {
            Catalog catalog = InterplayStorage.Catalogues
                .Where(catalogue => catalogue.name == InterplayStorage.SelectedCatalog.name).FirstOrDefault();

            if (catalog != null)
            {
                InterplayStorage.SelectedProductEntry = catalog.productEntries.Where(pe => pe.name == selectedProduct).FirstOrDefault();
            }
        }

        private void CreateArticlebuttons()
        {
            flowLayoutPanelArticle.Controls.Clear();

            List<SimpleArticle> simpleArticles = this.GetSimpleArticles();

            foreach (SimpleArticle article in simpleArticles)
            {
                InterplayPOSArticleButton button = new InterplayPOSArticleButton();
                button.Text = article.name;
                button.Click += article_button_click;
                flowLayoutPanelArticle.Controls.Add(button);
            }

        }

        private List<SimpleArticle> GetSimpleArticles()
        {
            List<SimpleArticle> simpleArticles = new List<SimpleArticle>();

            Catalog catalogue = InterplayStorage.Catalogues.Where(cat => cat.name == InterplayStorage.SelectedCatalog.name).FirstOrDefault();

            if (catalogue != null)
            {
                ProductEntry productEntry = catalogue.productEntries.Where(pe => pe.name == InterplayStorage.SelectedProductEntry.name).FirstOrDefault();
                if (productEntry != null && productEntry.articleEntries != null)
                {
                    foreach(ArticleEntry article in productEntry.articleEntries)
                    {
                        if(article.simpleArticles !=null)
                        {
                            simpleArticles.AddRange(article.simpleArticles);
                        }
                        else
                        {
                            simpleArticles.Add(new SimpleArticle
                            {
                                name = article.name,
                            });
                        }
                    }
                }
            }

            return simpleArticles;
        }

        private void article_button_click(object sender, EventArgs e)
        {
            this.SetSelectedArticle(((InterplayPOSArticleButton)sender).Text);
            Quantity quantityForm = new Quantity();
            quantityForm.ShowDialog();
            this.dgCart.DataSource = null;
            this.dgCart.Refresh();
            this.dgCart.DataSource = InterplayStorage.Cart.Items;
            this.lblTotal.Text = "  Total amount: " + InterplayStorage.Cart.NetAmount;
        }

        private void SetSelectedArticle(string selectedArticle)
        {
            List<SimpleArticle> articles = this.GetSimpleArticles();
            InterplayStorage.SelectedSimpleArticle = articles.Where(article => article.name == selectedArticle).FirstOrDefault();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanelProducts.Controls.Clear();
            flowLayoutPanelArticle.Controls.Clear();

            if (InterplayStorage.SelectedCatalog != null)
            {
                {
                    List<ProductEntry> productEntries = this.GetProductEntries().Where(product => product.name.ToLower().Contains(txtSearch.Text.ToLower())).ToList();

                    foreach (ProductEntry product in productEntries)
                    {
                        InterPlayPOSProductEntryButton button = new InterPlayPOSProductEntryButton();
                        button.Text = product.name;
                        button.Click += Product_Button_Click;
                        flowLayoutPanelProducts.Controls.Add(button);
                    }
                }
            }
        }
    }
}
