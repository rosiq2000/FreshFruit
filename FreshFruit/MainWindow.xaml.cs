﻿using FreshFruit.controller;
using FreshFruit.model;
using FruitSeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FreshFruit
{
    public partial class MainWindow : Window, BucketEventListener
    {

        Seller toni;

        public MainWindow()
        {
            InitializeComponent();

            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            toni = new Seller("toni", bucketController);

            ListBoxBucket.ItemsSource = keranjangBuah.findAll();
        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            toni.addFruit(anggur);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Fruit Apel = new Fruit("Apel");
            toni.addFruit(Apel);

        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Fruit Pisang = new Fruit("Pisang");
            toni.addFruit(Pisang);

        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Fruit jeruk = new Fruit("Jeruk");
            toni.addFruit(jeruk);

        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }
    }
}
