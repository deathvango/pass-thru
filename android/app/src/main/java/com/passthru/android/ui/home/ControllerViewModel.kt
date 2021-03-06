package com.passthru.android.ui.home

import androidx.lifecycle.LiveData
import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel

class ControllerViewModel : ViewModel() {

    private val _text = MutableLiveData<String>().apply {
        value = "Manage your controller connection"
    }
    val text: LiveData<String> = _text
}