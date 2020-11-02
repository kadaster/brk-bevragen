# coding: utf-8

"""
    Kadaster - BRK-Bevragen API

    D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van Kadastrale Onroerende Zaak informatie.   # noqa: E501

    The version of the OpenAPI document: 1.2.0
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class AantekeningAllOf(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'identificatie': 'str',
        'domein': 'str',
        'einddatum': 'date',
        'einddatum_recht': 'date'
    }

    attribute_map = {
        'identificatie': 'identificatie',
        'domein': 'domein',
        'einddatum': 'einddatum',
        'einddatum_recht': 'einddatumRecht'
    }

    def __init__(self, identificatie=None, domein=None, einddatum=None, einddatum_recht=None, local_vars_configuration=None):  # noqa: E501
        """AantekeningAllOf - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._identificatie = None
        self._domein = None
        self._einddatum = None
        self._einddatum_recht = None
        self.discriminator = None

        if identificatie is not None:
            self.identificatie = identificatie
        if domein is not None:
            self.domein = domein
        if einddatum is not None:
            self.einddatum = einddatum
        if einddatum_recht is not None:
            self.einddatum_recht = einddatum_recht

    @property
    def identificatie(self):
        """Gets the identificatie of this AantekeningAllOf.  # noqa: E501


        :return: The identificatie of this AantekeningAllOf.  # noqa: E501
        :rtype: str
        """
        return self._identificatie

    @identificatie.setter
    def identificatie(self, identificatie):
        """Sets the identificatie of this AantekeningAllOf.


        :param identificatie: The identificatie of this AantekeningAllOf.  # noqa: E501
        :type: str
        """

        self._identificatie = identificatie

    @property
    def domein(self):
        """Gets the domein of this AantekeningAllOf.  # noqa: E501

        Het domein waartoe de identificatie behoort.   # noqa: E501

        :return: The domein of this AantekeningAllOf.  # noqa: E501
        :rtype: str
        """
        return self._domein

    @domein.setter
    def domein(self, domein):
        """Sets the domein of this AantekeningAllOf.

        Het domein waartoe de identificatie behoort.   # noqa: E501

        :param domein: The domein of this AantekeningAllOf.  # noqa: E501
        :type: str
        """

        self._domein = domein

    @property
    def einddatum(self):
        """Gets the einddatum of this AantekeningAllOf.  # noqa: E501


        :return: The einddatum of this AantekeningAllOf.  # noqa: E501
        :rtype: date
        """
        return self._einddatum

    @einddatum.setter
    def einddatum(self, einddatum):
        """Sets the einddatum of this AantekeningAllOf.


        :param einddatum: The einddatum of this AantekeningAllOf.  # noqa: E501
        :type: date
        """

        self._einddatum = einddatum

    @property
    def einddatum_recht(self):
        """Gets the einddatum_recht of this AantekeningAllOf.  # noqa: E501


        :return: The einddatum_recht of this AantekeningAllOf.  # noqa: E501
        :rtype: date
        """
        return self._einddatum_recht

    @einddatum_recht.setter
    def einddatum_recht(self, einddatum_recht):
        """Sets the einddatum_recht of this AantekeningAllOf.


        :param einddatum_recht: The einddatum_recht of this AantekeningAllOf.  # noqa: E501
        :type: date
        """

        self._einddatum_recht = einddatum_recht

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, AantekeningAllOf):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, AantekeningAllOf):
            return True

        return self.to_dict() != other.to_dict()