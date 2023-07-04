import React from 'react'
import TopNav from '../layout/TopNav'

export const AppScreen = () => {
  return (
    <>
       <TopNav/>  
        <div className="p-tnav">
        <main>
  <div className="container-fluid px-5">
    <section className="page-header">
      <h2>Amazing Features</h2>
      <nav aria-label="breadcrumb">
        <ol className="breadcrumb foi-breadcrumb">
          <li className="breadcrumb-item">
            <a href="index.html">Home</a>
          </li>
          <li className="breadcrumb-item active" aria-current="page">
            About
          </li>
        </ol>
      </nav>
    </section>
    <section className="foi-page-section">
      <div className="row mb-5">
        <div className="col-md-4 foi-feature">
          <img
            src="assets/images/icon_1.png"
            alt="icon"
            className="feature-icon"
          />
          <h5 className="feature-title">Online Payment</h5>
          <p className="feature-content">
            Lorem ipsum dolor sit amt, consectet adop adipisicing elit, sed do
            eiusmod teporara incididunt ugt labore.
          </p>
          <a href="#!" className="feature-link">
            Find out More
          </a>
        </div>
        <div className="col-md-4 foi-feature">
          <img
            src="assets/images/icon_2.png"
            alt="icon"
            className="feature-icon"
          />
          <h5 className="feature-title">Online Payment</h5>
          <p className="feature-content">
            Lorem ipsum dolor sit amt, consectet adop adipisicing elit, sed do
            eiusmod teporara incididunt ugt labore.
          </p>
          <a href="#!" className="feature-link">
            Find out More
          </a>
        </div>
        <div className="col-md-4 foi-feature">
          <img
            src="assets/images/icon_3.png"
            alt="icon"
            className="feature-icon"
          />
          <h5 className="feature-title">Online Payment</h5>
          <p className="feature-content">
            Lorem ipsum dolor sit amt, consectet adop adipisicing elit, sed do
            eiusmod teporara incididunt ugt labore.
          </p>
          <a href="#!" className="feature-link">
            Find out More
          </a>
        </div>
      </div>
      <div className="row pt-5">
        <div className="col-md-4 foi-feature">
          <h5 className="feature-title">Secure Data</h5>
          <p className="feature-content">
            Lorem ipsum dolor sit amt, consectet adop adipisicing elit, sed do
            eiusmod teporara incididunt ugt labore.
          </p>
          <a href="#!" className="feature-link">
            Find out More
          </a>
        </div>
        <div className="col-md-4 foi-feature">
          <h5 className="feature-title">Live Chat</h5>
          <p className="feature-content">
            Lorem ipsum dolor sit amt, consectet adop adipisicing elit, sed do
            eiusmod teporara incididunt ugt labore.
          </p>
          <a href="#!" className="feature-link">
            Find out More
          </a>
        </div>
        <div className="col-md-4 foi-feature">
          <h5 className="feature-title">Equilizer Support</h5>
          <p className="feature-content">
            Lorem ipsum dolor sit amt, consectet adop adipisicing elit, sed do
            eiusmod teporara incididunt ugt labore.
          </p>
          <a href="#!" className="feature-link">
            Find out More
          </a>
        </div>
        <div className="col-md-4 foi-feature">
          <h5 className="feature-title">Fully functional</h5>
          <p className="feature-content">
            Lorem ipsum dolor sit amt, consectet adop adipisicing elit, sed do
            eiusmod teporara incididunt ugt labore.
          </p>
          <a href="#!" className="feature-link">
            Find out More
          </a>
        </div>
        <div className="col-md-4 foi-feature">
          <h5 className="feature-title">Powerful dashboard</h5>
          <p className="feature-content">
            Lorem ipsum dolor sit amt, consectet adop adipisicing elit, sed do
            eiusmod teporara incididunt ugt labore.
          </p>
          <a href="#!" className="feature-link">
            Find out More
          </a>
        </div>
        <div className="col-md-4 foi-feature">
          <h5 className="feature-title">Unlimited Features</h5>
          <p className="feature-content">
            Lorem ipsum dolor sit amt, consectet adop adipisicing elit, sed do
            eiusmod teporara incididunt ugt labore.
          </p>
          <a href="#!" className="feature-link">
            Find out More
          </a>
        </div>
      </div>
    </section>
    <section className="foi-page-section">
      <div className="row">
        <div className="col-md-6 mb-5 mb-md-0">
          <img
            src="assets/images/img_3.png"
            alt="faq"
            className="img-fluid"
            width="424px"
          />
        </div>
        <div className="col-md-6">
          <h2 className="feature-faq-title">Awesome Interface</h2>
          <div className="card feature-faq-card">
            <div className="card-header bg-white" id="featureFaqOneTitle">
              <a
                href="#featureFaqOneCollapse"
                className="d-flex align-items-center"
                data-toggle="collapse"
              >
                <h5 className="mb-0">How can I get a refund?</h5>{" "}
                <i className="far fa-plus-square ml-auto" />
              </a>
            </div>
            <div
              id="featureFaqOneCollapse"
              className="collapse"
              aria-labelledby="featureFaqOneTitle"
            >
              <div className="card-body">
                <p className="mb-0 text-gray">
                  Lorem Ipsum has been the industry's standard dummy text ever
                  since the 1500s, when an unknown printer took a galley of type
                  and scrambled it to make a type specimen book.
                </p>
              </div>
            </div>
          </div>
          <div className="card feature-faq-card">
            <div className="card-header bg-white" id="featureFaqTwoTitle">
              <a
                href="#featureFaqTwoCollapse"
                className="d-flex align-items-center"
                data-toggle="collapse"
              >
                <h5 className="mb-0">Which license should I need?</h5>{" "}
                <i className="far fa-plus-square ml-auto" />
              </a>
            </div>
            <div
              id="featureFaqTwoCollapse"
              className="collapse"
              aria-labelledby="featureFaqTwoTitle"
            >
              <div className="card-body">
                <p className="mb-0 text-gray">
                  Lorem Ipsum has been the industry's standard dummy text ever
                  since the 1500s, when an unknown printer took a galley of type
                  and scrambled it to make a type specimen book.
                </p>
              </div>
            </div>
          </div>
          <div className="card feature-faq-card">
            <div className="card-header bg-white" id="featureFaqThreeTitle">
              <a
                href="#featureFaqThreeCollapse"
                className="d-flex align-items-center"
                data-toggle="collapse"
              >
                <h5 className="mb-0">
                  How do I get a receipt for my purchase?
                </h5>{" "}
                <i className="far fa-plus-square ml-auto" />
              </a>
            </div>
            <div
              id="featureFaqThreeCollapse"
              className="collapse"
              aria-labelledby="featureFaqThreeTitle"
            >
              <div className="card-body">
                <p className="mb-0 text-gray">
                  Lorem Ipsum has been the industry's standard dummy text ever
                  since the 1500s, when an unknown printer took a galley of type
                  and scrambled it to make a type specimen book.
                </p>
              </div>
            </div>
          </div>
          <div className="card feature-faq-card">
            <div className="card-header bg-white" id="featureFaqFourTitle">
              <a
                href="#featureFaqFourCollapse"
                className="d-flex align-items-center"
                data-toggle="collapse"
              >
                <h5 className="mb-0">How do I report an issue?</h5>{" "}
                <i className="far fa-plus-square ml-auto" />
              </a>
            </div>
            <div
              id="featureFaqFourCollapse"
              className="collapse"
              aria-labelledby="featureFaqFourTitle"
            >
              <div className="card-body">
                <p className="mb-0 text-gray">
                  Lorem Ipsum has been the industry's standard dummy text ever
                  since the 1500s, when an unknown printer took a galley of type
                  and scrambled it to make a type specimen book.
                </p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
  </div>
</main>


        </div>
    </>   
  )
}
